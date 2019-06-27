namespace Promat.Translations.Models
{
    public class TranslationInfo
    {
        public string Language { get; }
        public string Text { get; }

        public TranslationInfo(string language, string text)
        {
            Language = language;
            Text = text;
        }
        public override string ToString() => $"{nameof(Language)}: {Language}, {nameof(Text)}: {Text}";
    }
}
