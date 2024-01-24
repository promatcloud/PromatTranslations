using Newtonsoft.Json;
using Promat.Translations.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Promat.Translations.Models
{
    public class Translation
    {
        public string TextToTranslate { get; }
        public string LanguageFromTranslate { get; } = "es";
        public string[] LanguagesToTranslate { get; }
        public List<TranslationInfo> TranslatedText { get; private set; }

        private string UrlToQuery => string.Format(Constants.Constants.TranslationUrl, LanguageFromTranslate) + string.Concat(LanguagesToTranslate.Select(lang => $"&to={lang}"));//&to={1}, LanguageToTranslate);
        private string TextBody => JsonConvert.SerializeObject(new object[] { new { Text = TextToTranslate } });

        /// <summary>
        /// Create a new instance of <see cref="Translation"/> supplying <see cref="TextToTranslate"/> and <see cref="LanguagesToTranslate"/> values.
        /// <see cref="LanguageFromTranslate"/> assumes its default value "es-ES".
        /// </summary>
        /// <param name="textToTranslate">Text to be translated. Maximum 5000 characters or a <see cref="ArgumentOutOfRangeException"/> will be throw</param>
        /// <param name="languagesToTranslate">Language/s to which the <see cref="textToTranslate"/> will be translated. At least one, an all not null or emptry; or a <see cref="ArgumentNullException"/> will be throw</param>
        public Translation(string textToTranslate, params Languages[] languagesToTranslate)
        {
            TextToTranslate = textToTranslate ?? string.Empty;

            if (TextToTranslate.Length > 5000)
            {
                throw new ArgumentOutOfRangeException(nameof(textToTranslate), "The maximum length allowed is 5000 characters");
            }

            if (languagesToTranslate == null || languagesToTranslate.Length <= 0)
            {
                throw new ArgumentNullException(nameof(languagesToTranslate), "Must pass, at least, one language to translate");
            }

            LanguagesToTranslate = languagesToTranslate.Select(Constants.Constants.GetLanguageCode).ToArray();
        }
        /// <summary>
        /// Create a new instance of <see cref="Translation"/> supplying <see cref="TextToTranslate"/>, <see cref="LanguageFromTranslate"/> and <see cref="LanguagesToTranslate"/> values.
        /// </summary>
        /// <param name="textToTranslate">Text to be translated. Maximum 5000 characters or a <see cref="ArgumentOutOfRangeException"/> will be throw</param>
        /// <param name="languageFromTranslate">Language of the <see cref="languageFromTranslate"/>. Can't be null or a <see cref="ArgumentNullException"/> will be throw</param>
        /// <param name="languagesToTranslate">Language/s to which the <see cref="textToTranslate"/> will be translated. At least one, an all not null or emptry; or a <see cref="ArgumentNullException"/> will be throw</param>
        public Translation(string textToTranslate, Languages languageFromTranslate, Languages[] languagesToTranslate)
        {
            TextToTranslate = textToTranslate ?? string.Empty;

            if (TextToTranslate.Length > 5000)
            {
                throw new ArgumentOutOfRangeException(nameof(textToTranslate), "The maximum length allowed is 5000 characters");
            }

            LanguageFromTranslate = Constants.Constants.GetLanguageCode(languageFromTranslate);

            if (languagesToTranslate == null || languagesToTranslate.Length <= 0)
            {
                throw new ArgumentNullException(nameof(languagesToTranslate), "Must pass, at least, one language to translate");
            }

            LanguagesToTranslate = languagesToTranslate.Select(Constants.Constants.GetLanguageCode).ToArray();
        }

        public async Task<List<TranslationInfo>> TranslateAsync()
        {
            if (TranslatedText == null)
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, new Uri(UrlToQuery)))
                {
                    request.Content = new StringContent(TextBody, Encoding.UTF8, "application/json");

                    var response = await TranslationStaticResourcesManager.SendAuthorizedAsync(request);

                    // Too Many Requests
                    if ((int)response.StatusCode == 429)
                    {
                        var retryNumber = 0;
                        do
                        {
                            retryNumber++;
                            await Task.Delay(100 * retryNumber);
                            response = await TranslationStaticResourcesManager.SendAuthorizedAsync(request);
                        } while ((int)response.StatusCode == 429 && retryNumber <= 5);
                    }

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException($"The server responded incorrectly. {nameof(response.StatusCode)}: {response.StatusCode}. {nameof(response.ReasonPhrase)}: {response.ReasonPhrase}");
                    }

                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var translationResponse = JsonConvert.DeserializeObject<TranslationResponse[]>(jsonResponse)[0];
                    TranslatedText = translationResponse.Translations.Select(t => new TranslationInfo(t.To, t.Text)).ToList();
                }
            }

            return TranslatedText;
        }
    }
}
