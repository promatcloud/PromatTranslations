using System;
using PromatTranslations.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PromatTranslations.Constants;

namespace PromatTranslations
{
    public static class PromatTranslator
    {
        private static Languages _from = Languages.Español;

        /// <summary>
        /// Configure <see cref="PromatTranslator"/> with <see cref="IConfiguration"/>.
        /// A key <see cref="Constants.Constants.AzureApiKeyConfigurationKey"/> (AzureApiKey) will be getted from <see cref="IConfiguration"/> in order to configure de the Azure Translator Text API key
        /// </summary>
        /// <param name="configuration"></param>
        public static void Configure(IConfiguration configuration)
        {
            ConfigureKey(configuration[Constants.Constants.AzureApiKeyConfigurationKey]);
        }
        /// <summary>
        /// Configure <see cref="PromatTranslator"/> with the Azure Translator Text API key
        /// </summary>
        /// <param name="azureTranslatorTextApiKey">The key provided you by Azure</param>
        public static void ConfigureKey(string azureTranslatorTextApiKey)
        {
            TranslationStaticResourcesManager.SetAzureTranslatorKey(azureTranslatorTextApiKey);
        }
        /// <summary>
        /// Get a list of available languages to translate from the Azure API
        /// </summary>
        /// <param name="language">The language in which the languages in the list will come</param>
        /// <returns></returns>
        public static Task<List<(string languageCode, string languageName)>> GetAvailableTranslationLanguages(Languages language = Languages.Español) => TranslationStaticResourcesManager.GetAvailableTranslationLanguages(language);
        /// <summary>
        /// Configure de From Language for the translations.
        /// </summary>
        /// <param name="language"></param>
        public static void ConfigureLanguageFrom(Languages language) => _from = language;

        /// <summary>
        /// Translate the text passed as a parameter to the indicated language, from the configured "language from" (spanish by default)
        /// </summary>
        /// <param name="textToTranslate">The text that will be translated</param>
        /// <param name="languageToTranslate">The language to translate.</param>
        /// <returns></returns>
        public static async Task<string> TranslateAsync(string textToTranslate, Languages languageToTranslate)
        {
            var manager = new TranslationManager(new[] { textToTranslate }, _from, new[] { languageToTranslate });
            var result = await manager.TranslateAsync();
            return result.First().First().Text;
        }

        /// <summary>
        /// Translate the text passed as a parameter to the indicated language, from the configured "language from" (spanish by default)
        /// </summary>
        /// <param name="textToTranslate">The text that will be translated</param>
        /// <param name="languageToTranslate">The language to translate.</param>
        /// <param name="progressChangedHandler">A handler to invoke for each reported translation progress value.</param>
        /// <returns></returns>
        public static async Task<string> TranslateAsync(string textToTranslate, Languages languageToTranslate, Action<(int currentTranslation, int totalTranslations)> progressChangedHandler)
        {
            var manager = new TranslationManager(progressChangedHandler, new[] { textToTranslate }, _from, new[] { languageToTranslate });
            var result = await manager.TranslateAsync();
            return result.First().First().Text;
        }

        /// <summary>
        /// Translate the texts passed in the enumerable parameter to the indicated language, assuming that we start from texts in Spanish
        /// </summary>
        /// <param name="textsToTranslate">The texts that will be translated</param>
        /// <param name="languageToTranslate">The language to translate.</param>
        /// <returns></returns>
        public static async Task<List<string>> TranslateAsync(IEnumerable<string> textsToTranslate, Languages languageToTranslate)
        {
            var manager = new TranslationManager(textsToTranslate.ToArray(), _from, new[] { languageToTranslate });
            var result = await manager.TranslateAsync();
            return result.Select(item => item.First().Text).ToList();
        }

        /// <summary>
        /// Translate the texts passed in the enumerable parameter to the indicated language, assuming that we start from texts in Spanish
        /// </summary>
        /// <param name="textsToTranslate">The texts that will be translated</param>
        /// <param name="languageToTranslate">The language to translate.</param>
        /// <param name="progressChangedHandler">A handler to invoke for each reported translation progress value.</param>
        /// <returns></returns>
        public static async Task<List<string>> TranslateAsync(IEnumerable<string> textsToTranslate, Languages languageToTranslate, Action<(int currentTranslation, int totalTranslations)> progressChangedHandler)
        {
            var manager = new TranslationManager(progressChangedHandler, textsToTranslate.ToArray(), _from, new[] { languageToTranslate });
            var result = await manager.TranslateAsync();
            return result.Select(item => item.First().Text).ToList();
        }
    }
}
