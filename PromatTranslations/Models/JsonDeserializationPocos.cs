namespace PromatTranslations.Models {
    internal class TranslationInternalTuple
    {
        public string Text { get; set; }
        public string To { get; set; }
    }
    internal class TranslationResponse
    {
        public TranslationInternalTuple[] Translations { get; set; }
    }
}