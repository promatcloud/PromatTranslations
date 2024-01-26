using Newtonsoft.Json;
using Promat.Translations.Constants;
using Promat.Translations.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Promat.Translations
{
    internal static class TranslationStaticResourcesManager
    {
        private static HttpClient HttpClient { get; } = new HttpClient();
        private static string AuthorizationToken { get; set; }
        private static DateTime? LastAuthorizationTokenUsage { get; set; }
        private static string AzureTranslatorTextApiKey { get; set; }
        private static string AzureTranslatorRegionPrefix { get; set; }
        private static bool _requestingToken = false;
        private static int BaseMillisecondsForTooManyRequestRetry { get; set; } = 1000;

        private static async Task EnsureAuthorizedAsync()
        {
            CheckAzureTranslatorTextApiKey();
            if (!_requestingToken && (LastAuthorizationTokenUsage == null || DateTime.Now.Subtract(LastAuthorizationTokenUsage.Value) > TimeSpan.FromMinutes(8)))
            {
                _requestingToken = true;
                string url;
                if (string.IsNullOrWhiteSpace(AzureTranslatorRegionPrefix) || string.Equals(AzureTranslatorRegionPrefix,
                        "global", StringComparison.InvariantCultureIgnoreCase))
                {
                    url = string.Format(Constants.Constants.AuthenticationServiceUrl, string.Empty);
                }
                else
                {
                    url = string.Format(Constants.Constants.AuthenticationServiceUrl, AzureTranslatorRegionPrefix + ".");
                }

                using (var request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    request.Headers.Add(Constants.Constants.SubscriptionKeyHeaderKey, AzureTranslatorTextApiKey);

                    var response = await HttpClient.SendAsync(request);

                    if (response.StatusCode == HttpStatusCode.Forbidden && response.ReasonPhrase == "quota limit is reached")
                    {
                        throw new QuotaExceededException(await response.Content.ReadAsStringAsync());
                    }
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new HttpRequestException($"Can't get Authorization Token from \"{url}\". StatusCode: {response.StatusCode}, Reason: {response.ReasonPhrase}, Content: {await response.Content.ReadAsStringAsync()}");
                    }
                    AuthorizationToken = await response.Content.ReadAsStringAsync();
                    LastAuthorizationTokenUsage = DateTime.Now;

                    HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AuthorizationToken);
                }

                _requestingToken = false;
            }
        }
        internal static async Task<HttpResponseMessage> SendAuthorizedAsync(HttpRequestMessage request)
        {
            while (_requestingToken)
            {
                await Task.Delay(100);
            }
            await EnsureAuthorizedAsync();
            using (var requestClone = await CloneRequestAsync(request))
            {
                var response = await HttpClient.SendAsync(requestClone);

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    LastAuthorizationTokenUsage = null;
                    await EnsureAuthorizedAsync();
                    using (var requestClone2 = await CloneRequestAsync(request))
                    {
                        return await HttpClient.SendAsync(requestClone2);
                    }
                }

                LastAuthorizationTokenUsage = DateTime.Now;
                return response;
            }
        }

        private static async Task<HttpRequestMessage> CloneRequestAsync(HttpRequestMessage request)
        {
            var message = new HttpRequestMessage(request.Method, request.RequestUri);
            message.Content = request.Content;
            if (request.Content is StringContent stringContent)
            {
                message.Content = new StringContent(await stringContent.ReadAsStringAsync(), Encoding.UTF8, "application/json");
            }
            return message;
        }
        internal static async Task<List<(string languageCode, string languageName)>> GetAvailableTranslationLanguages(Languages language = Languages.Español)
        {
            var result = new List<(string code, string name)>();
            using (var request = new HttpRequestMessage(HttpMethod.Get, "https://api.cognitive.microsofttranslator.com/languages?api-version=3.0&scope=translation"))
            {
                request.Headers.Add("Accept-Language", Constants.Constants.GetLanguageCode(language));
                var response = await HttpClient.SendAsync(request);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var translationResponse = JsonConvert.DeserializeObject<RootObject>(jsonResponse);
                foreach (var keyValuePair in translationResponse.translation)
                {
                    result.Add((keyValuePair.Key, keyValuePair.Value.name));
                }
            }
            return result;
        }

        internal static void SetAzureTranslatorKey(string key)
        {
            AzureTranslatorTextApiKey = key;
            LastAuthorizationTokenUsage = null;
        }
        internal static void SetAzureTranslatorRegionPrefix(string regionPrefix)
        {
            AzureTranslatorRegionPrefix = regionPrefix;
        }

        /// <summary>
        /// Establece los milisegundos base para reintentar después de recibir una respuesta de "TooManyRequest".
        /// El tiempo de espera para el reintento será:  BaseMillisecondsForTooManyRequestRetry * retryNumber + accumulatedDelay.
        /// Valor por defecto: 1000
        /// </summary>
        internal static void SetBaseMillisecondsForTooManyRequestRetry(int baseMillisecondsForTooManyRequestRetry)
        {
            if (baseMillisecondsForTooManyRequestRetry < 0)
            {
                throw new ArgumentException(nameof(baseMillisecondsForTooManyRequestRetry), $"The {baseMillisecondsForTooManyRequestRetry} parameter can't be negative.");
            }
            BaseMillisecondsForTooManyRequestRetry = baseMillisecondsForTooManyRequestRetry;
        }

        /// <summary>
        /// Get los milisegundos base para reintentar después de recibir una respuesta de "TooManyRequest".
        /// El tiempo de espera para el reintento será:  BaseMillisecondsForTooManyRequestRetry * retryNumber + accumulatedDelay.
        /// Valor por defecto: 1000
        /// </summary>
        internal static int GetBaseMillisecondsForTooManyRequestRetry()
        {
            return BaseMillisecondsForTooManyRequestRetry;
        }

        private static void CheckAzureTranslatorTextApiKey()
        {
            if (string.IsNullOrWhiteSpace(AzureTranslatorTextApiKey))
            {
                throw new ArgumentException(nameof(AzureTranslatorTextApiKey), $"The {AzureTranslatorTextApiKey} parameter isn't setted. Please, call {nameof(PromatTranslator)}.{nameof(PromatTranslator.ConfigureKey)} or {nameof(PromatTranslator)}.{nameof(PromatTranslator.Configure)} before use any other method.");
            }
        }

        private class RootObject
        {
            public Dictionary<string, LanguageDescription> translation { get; set; }
        }

        private class LanguageDescription
        {
            public string name { get; set; }
            public string nativeName { get; set; }
            public string dir { get; set; }
        }
    }
}