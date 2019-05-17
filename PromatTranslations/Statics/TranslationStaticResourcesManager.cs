using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PromatTranslations.Constants;

namespace PromatTranslations
{
    internal static class TranslationStaticResourcesManager
    {
        private static HttpClient HttpClient { get; } = new HttpClient();
        private static string AuthorizationToken { get; set; }
        private static DateTime? LastAuthorizationTokenUsage { get; set; }
        private static string AzureTranslatorTextApiKey { get; set; }
        private static bool _requestingToken = false;

        private static async Task EnsureAuthorizedAsync()
        {
            CheckAzureTranslatorTextApiKey();
            if (!_requestingToken && (LastAuthorizationTokenUsage == null || DateTime.Now.Subtract(LastAuthorizationTokenUsage.Value) > TimeSpan.FromMinutes(8)))
            {
                _requestingToken = true;

                using (var request = new HttpRequestMessage(HttpMethod.Post, Constants.Constants.AuthenticationServiceUrl))
                {
                    request.Headers.Add(Constants.Constants.SubscriptionKeyHeaderKey, AzureTranslatorTextApiKey);

                    var response = await HttpClient.SendAsync(request);

                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new HttpRequestException($"Can't get Authorization Token from \"{Constants.Constants.AuthenticationServiceUrl}\"");
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
            var response = await HttpClient.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                LastAuthorizationTokenUsage = null;
                await EnsureAuthorizedAsync();
                return await HttpClient.SendAsync(request);
            }

            LastAuthorizationTokenUsage = DateTime.Now;
            return response;
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