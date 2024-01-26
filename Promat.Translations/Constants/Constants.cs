namespace Promat.Translations.Constants
{
    public static class Constants
    {
        public const string TranslationUrl = "https://api.cognitive.microsofttranslator.com/translate?api-version=3.0&from={0}";
        public const string AuthenticationServiceUrl = "https://{0}api.cognitive.microsoft.com/sts/v1.0/issueToken";
        public const string AzureApiKeyConfigurationKey = "AzureApiKey";
        public const string AzureApiRegionConfigurationKey = "AzureApiRegion";
        public const string SubscriptionKeyHeaderKey = "Ocp-Apim-Subscription-Key";
        public const int MaximumCharsToTranslate = 5000;

        internal static string GetLanguageCode(Languages language)
        {
            switch (language)
            {
                case Languages.Afrikaans:
                    return "af";
                case Languages.Arabe:
                    return "ar";
                case Languages.Bulgaro:
                    return "bg";
                case Languages.Bangla:
                    return "bn";
                case Languages.Bosnio:
                    return "bs";
                case Languages.Catalan:
                    return "ca";
                case Languages.Checo:
                    return "cs";
                case Languages.Gales:
                    return "cy";
                case Languages.Danes:
                    return "da";
                case Languages.Aleman:
                    return "de";
                case Languages.Griego:
                    return "el";
                case Languages.Ingles:
                    return "en";
                case Languages.Español:
                    return "es";
                case Languages.Estonio:
                    return "et";
                case Languages.Persa:
                    return "fa";
                case Languages.Finlandes:
                    return "fi";
                case Languages.Filipino:
                    return "fil";
                case Languages.Fiyiano:
                    return "fj";
                case Languages.Frances:
                    return "fr";
                case Languages.Hebreo:
                    return "he";
                case Languages.Hindi:
                    return "hi";
                case Languages.Croata:
                    return "hr";
                case Languages.CriolloHaitiano:
                    return "ht";
                case Languages.Hungaro:
                    return "hu";
                case Languages.Indonesio:
                    return "id";
                case Languages.Islandes:
                    return "is";
                case Languages.Italiano:
                    return "it";
                case Languages.Japones:
                    return "ja";
                case Languages.Coreano:
                    return "ko";
                case Languages.Lituano:
                    return "lt";
                case Languages.Leton:
                    return "lv";
                case Languages.Malgache:
                    return "mg";
                case Languages.Malayo:
                    return "ms";
                case Languages.Maltes:
                    return "mt";
                case Languages.HmongDaw:
                    return "mww";
                case Languages.Noruego:
                    return "nb";
                case Languages.Holandes:
                    return "nl";
                case Languages.OtomiQueretaro:
                    return "otq";
                case Languages.Polaco:
                    return "pl";
                case Languages.Portugues:
                    return "pt";
                case Languages.Rumano:
                    return "ro";
                case Languages.Ruso:
                    return "ru";
                case Languages.Eslovaco:
                    return "sk";
                case Languages.Esloveno:
                    return "sl";
                case Languages.Samoano:
                    return "sm";
                case Languages.SerbioCirilico:
                    return "sr-Cyrl";
                case Languages.SerbioLatino:
                    return "sr-Latn";
                case Languages.Sueco:
                    return "sv";
                case Languages.Kiswahili:
                    return "sw";
                case Languages.Tamil:
                    return "ta";
                case Languages.Telugu:
                    return "te";
                case Languages.Tailandes:
                    return "th";
                case Languages.Klingon:
                    return "tlh";
                case Languages.Tongano:
                    return "to";
                case Languages.Turco:
                    return "tr";
                case Languages.Tahitiano:
                    return "ty";
                case Languages.Ucraniano:
                    return "uk";
                case Languages.Urdu:
                    return "ur";
                case Languages.Vietnamita:
                    return "vi";
                case Languages.MayaYucateco:
                    return "yua";
                case Languages.Cantonestraditional:
                    return "yue";
                case Languages.Chinosimplificado:
                    return "zh-Hans";
                case Languages.Chinotradicional:
                    return "zh-Hant";
                default:
                    return null;
            }
        }
    }
}