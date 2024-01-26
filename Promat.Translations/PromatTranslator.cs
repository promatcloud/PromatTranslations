using Microsoft.Extensions.Configuration;
using Promat.Translations.Constants;
using Promat.Translations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promat.Translations
{
    public static class PromatTranslator
    {
        private static Languages _from = Languages.Español;

        /// <summary>
        /// Configure <see cref="PromatTranslator"/> with <see cref="IConfiguration"/>.
        /// A key <see cref="Constants.AzureApiKeyConfigurationKey"/> (AzureApiKey) will be got from <see cref="IConfiguration"/> in order to configure de the Azure Translator Text API key
        /// A key <see cref="Constants.AzureApiRegionConfigurationKey"/> (AzureApiRegion) will be got from <see cref="IConfiguration"/> in order to configure de the Azure Translator Text API region
        /// </summary>
        /// <param name="configuration"></param>
        public static void Configure(IConfiguration configuration)
        {
            ConfigureKey(configuration[Constants.Constants.AzureApiKeyConfigurationKey]);
            ConfigureRegionPrefix(configuration[Constants.Constants.AzureApiRegionConfigurationKey]);
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
        /// Configure <see cref="PromatTranslator"/> with the Azure Translator Resource Region
        /// </summary>
        /// <param name="azureTranslatorRegionPrefix">Regio prefix for use in API urls</param>
        public static void ConfigureRegionPrefix(string azureTranslatorRegionPrefix)
        {
            TranslationStaticResourcesManager.SetAzureTranslatorRegionPrefix(azureTranslatorRegionPrefix);
        }
        /// <summary>
        /// Establece los milisegundos base para reintentar después de recibir una respuesta de "TooManyRequest".
        /// El tiempo de espera para el reintento será:  BaseMillisecondsForTooManyRequestRetry * retryNumber + accumulatedDelay.
        /// Valor por defecto: 200
        /// </summary>
        /// <param name="baseMillisecondsForTooManyRequestRetry">Los milisegundos base para reintentar después de recibir una respuesta de "TooManyRequest"</param>
        public static void ConfigureBaseMillisecondsForTooManyRequestRetry(int baseMillisecondsForTooManyRequestRetry)
        {
            TranslationStaticResourcesManager.SetBaseMillisecondsForTooManyRequestRetry(baseMillisecondsForTooManyRequestRetry);
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
            var manager = new TranslationManager(new[] { textToTranslate }, _from, new[] { languageToTranslate })
            {
                BaseMillisecondsForTooManyRequestRetry = TranslationStaticResourcesManager.GetBaseMillisecondsForTooManyRequestRetry()
            };
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
            var manager = new TranslationManager(progressChangedHandler, new[] { textToTranslate }, _from, new[] { languageToTranslate })
            {
                BaseMillisecondsForTooManyRequestRetry = TranslationStaticResourcesManager.GetBaseMillisecondsForTooManyRequestRetry()
            };
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
            var manager = new TranslationManager(textsToTranslate.ToArray(), _from, new[] { languageToTranslate })
            {
                BaseMillisecondsForTooManyRequestRetry = TranslationStaticResourcesManager.GetBaseMillisecondsForTooManyRequestRetry()
            };
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
            var manager = new TranslationManager(progressChangedHandler, textsToTranslate.ToArray(), _from, new[] { languageToTranslate })
            {
                BaseMillisecondsForTooManyRequestRetry = TranslationStaticResourcesManager.GetBaseMillisecondsForTooManyRequestRetry()
            };
            var result = await manager.TranslateAsync();
            return result.Select(item => item.First().Text).ToList();
        }
    }
}
