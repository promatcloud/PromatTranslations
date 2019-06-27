using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Promat.Translations.Constants;

namespace Promat.Translations.Models
{
    public class TranslationManager : Progress<(int currentTranslation, int totalTranslations)>
    {
        private const string BeginTextNumberPattern = "%{0}% ";
        private const string BeginTextNumberRegularExpression = @"%.*\d.*% ?";

        public string[] TextsToTranslate { get; private set; }
        public Languages LanguageFromTranslate { get; } = Languages.Español;
        public Languages[] LanguagesToTranslate { get; private set; }
        public List<List<TranslationInfo>> TranslatedTexts { get; private set; }

        public TranslationManager(IEnumerable<string> textToTranslate, params Languages[] languagesToTranslate) => CommonConstruction(textToTranslate, languagesToTranslate);
        public TranslationManager(Action<(int currentTranslation, int totalTranslations)> progressChangedHandler, IEnumerable<string> textToTranslate, params Languages[] languagesToTranslate) : base(progressChangedHandler)
        {
            CommonConstruction(textToTranslate, languagesToTranslate);
        }
        public TranslationManager(IEnumerable<string> textToTranslate, Languages languageFromTranslate, Languages[] languagesToTranslate)
        {
            CommonConstruction(textToTranslate, languagesToTranslate);
            LanguageFromTranslate = languageFromTranslate;
        }
        public TranslationManager(Action<(int currentTranslation, int totalTranslations)> progressChangedHandler, IEnumerable<string> textToTranslate, Languages languageFromTranslate, Languages[] languagesToTranslate) : base(progressChangedHandler)
        {
            CommonConstruction(textToTranslate, languagesToTranslate);
            LanguageFromTranslate = languageFromTranslate;
        }

        public async Task<List<List<TranslationInfo>>> TranslateAsync()
        {
            var rawTranslatedTexts = new List<List<TranslationInfo>>();
            var textsForTranslate = PrepareTexts();

            var totalTranslations = textsForTranslate.Count;
            var currentTranslation = 0;
            var translationTasks = new List<Task<List<TranslationInfo>>>();
            var notificationsTasks = new List<Task>();

            foreach (var textToTranslate in textsForTranslate)
            {
                var translation = new Translation(textToTranslate, LanguageFromTranslate, LanguagesToTranslate);

                var translationTask = translation.TranslateAsync();
                notificationsTasks.Add(translationTask.ContinueWith(t =>
                {
                    currentTranslation++;
                    OnReport((currentTranslation, totalTranslations));
                }));
                translationTasks.Add(translationTask);
            }

            await Task.WhenAll(translationTasks);

            foreach (var translationTask in translationTasks)
            {
                rawTranslatedTexts.Add(translationTask.Result);
            }

            TranslatedTexts = GetRecomposedTranslatedTexts(rawTranslatedTexts);

            await Task.WhenAll(notificationsTasks);

            return TranslatedTexts;
        }
        public List<List<TranslationInfo>> TestRecomposedTranslatedTexts(List<List<TranslationInfo>> rawTranslations) => GetRecomposedTranslatedTexts(rawTranslations);
        public List<string> TestPrepateText() => PrepareTexts();

        private void CommonConstruction(IEnumerable<string> textToTranslate, Languages[] languagesToTranslate)
        {
            TextsToTranslate = (textToTranslate ?? new[] { string.Empty }).Select(t => t?.Trim()).ToArray();
            if (languagesToTranslate == null || languagesToTranslate.Length <= 0)
            {
                throw new ArgumentNullException(nameof(languagesToTranslate), "Must pass, at least, one language to translate");
            }

            LanguagesToTranslate = languagesToTranslate;
        }
        private List<List<TranslationInfo>> GetRecomposedTranslatedTexts(List<List<TranslationInfo>> rawTranslations)
        {
            var result = new List<List<TranslationInfo>>(TextsToTranslate.Length);
            var dicLanguages = new Dictionary<string, List<string>>();
            var dicResult = new Dictionary<string, List<string>>();
            var languages = LanguagesToTranslate.Select(Constants.Constants.GetLanguageCode).ToList();

            foreach (var language in languages)
            {
                dicLanguages.Add(language, new List<string>());
                foreach (var rawTranslation in rawTranslations)
                {
                    dicLanguages[language].AddRange(rawTranslation.Where(info => info.Language == language).Select(info => info.Text).ToArray());
                }
            }

            foreach (var dicEntry in dicLanguages)
            {
                var accumulated = string.Empty;
                foreach (var text in dicEntry.Value)
                {
                    var matches = Regex.Matches(text, BeginTextNumberRegularExpression);

                    if (matches.Count == 0)
                    {
                        accumulated += string.IsNullOrWhiteSpace(accumulated) ? text : $" {text}";
                    }
                    else
                    {
                        if (!dicResult.ContainsKey(dicEntry.Key))
                        {
                            dicResult.Add(dicEntry.Key, new List<string>());
                        }

                        if (!string.IsNullOrWhiteSpace(accumulated))
                        {
                            dicResult[dicEntry.Key].Add(accumulated);
                            accumulated = string.Empty;
                        }

                        if (matches.Count == 1)
                        {
                            var startIndex = matches[0].Index + matches[0].Length;
                            accumulated += text.Substring(startIndex);
                        }
                        else
                        {
                            foreach (Match match in matches)
                            {
                                var nextMatch = match.NextMatch();
                                var startIndex = match.Index + match.Length;
                                dicResult[dicEntry.Key].Add(nextMatch.Success ? text.Substring(startIndex, nextMatch.Index - startIndex) : text.Substring(startIndex));
                            }
                        }
                    }
                }

                if (!string.IsNullOrWhiteSpace(accumulated))
                {
                    dicResult[dicEntry.Key].Add(accumulated);
                }
            }

            for (int i = 0; i < result.Capacity; i++)
            {
                result.Add(new List<TranslationInfo>());

                foreach (var dicEntry in dicResult)
                {
                    var resultText = dicEntry.Value[i];

                    if (resultText.EndsWith(Environment.NewLine))
                    {
                        resultText = resultText.Substring(0, resultText.LastIndexOf(Environment.NewLine, StringComparison.InvariantCultureIgnoreCase));
                    }

                    result[i].Add(new TranslationInfo(dicEntry.Key, resultText));
                }
            }

            return result;
        }
        private List<string> PrepareTexts()
        {
            var preparedTexts = new List<string>();
            var numberedTexts = new List<string>();
            var numberOfLine = 0;

            foreach (var text in TextsToTranslate)
            {
                numberOfLine++;
                numberedTexts.Add($"{string.Format(BeginTextNumberPattern, numberOfLine)}{text}");
            }

            var package = string.Empty;

            foreach (var text in numberedTexts)
            {
                if (text.Length > Constants.Constants.MaximumCharsToTranslate)
                {
                    if (!string.IsNullOrWhiteSpace(package))
                    {
                        preparedTexts.Add(package);
                        package = string.Empty;
                    }

                    foreach (var part in GenerateParagraphs(text, Constants.Constants.MaximumCharsToTranslate))
                    {
                        preparedTexts.Add(part);
                    }
                }
                else
                {
                    if (package.Length + Environment.NewLine.Length + text.Length > Constants.Constants.MaximumCharsToTranslate)
                    {
                        preparedTexts.Add(package);
                        package = string.Empty;
                    }
                    package += string.IsNullOrWhiteSpace(package) ? text : Environment.NewLine + text;
                }
            }

            if (!string.IsNullOrWhiteSpace(package))
            {
                preparedTexts.Add(package);
            }

            return preparedTexts;
        }
        private string[] GenerateParagraphs(string stringParagraph, int lengthParagraph)
        {
            if (stringParagraph == null)
            {
                throw new ArgumentNullException(nameof(stringParagraph), "Value can not be null");
            }

            if (lengthParagraph < 0)
            {
                throw new ArgumentException("Negative values not allowed.", nameof(lengthParagraph));
            }

            if (lengthParagraph >= stringParagraph.Length)
            {
                return new[] { stringParagraph };
            }

            var nonWordCharacters = new HashSet<char> { ',', '.', ':', ';' };
            //var final = string.Empty;
            var result = new List<string>();

            int total = 0;
            int begin = 0;
            string valueToCrop = stringParagraph;

            while (total < stringParagraph.Length)
            {
                int end = lengthParagraph;

                if (lengthParagraph < valueToCrop.Length)
                {
                    for (int i = end - 1; i > 0; i--)
                    {
                        if (valueToCrop[i] == ' ' || valueToCrop[i] == '\n' || valueToCrop[i] == '\t')
                        {
                            break;
                        }

                        if (nonWordCharacters.Contains(valueToCrop[i])
                            && (valueToCrop.Length == i + 1 || valueToCrop[i + 1] == ' '))
                        {
                            //Removing a character that isn't whitespace but not part 
                            //of the word either (ie ".") given that the character is 
                            //followed by whitespace or the end of the string makes it
                            //possible to include the word, so we do that.
                            break;
                        }

                        end--;
                    }

                    if (end == 0)
                    {
                        //If the first word is longer than the length we favor 
                        //returning it as cropped over returning nothing at all.
                        end = lengthParagraph;
                    }
                }
                else
                {
                    end = valueToCrop.Length;
                }

                result.Add(stringParagraph.Substring(begin, end).Trim());
                //final = $"{final}{(!string.IsNullOrWhiteSpace(final) ? Environment.NewLine : "")}{stringParagraph.Substring(begin, end).Trim()}";

                total = total + end;
                valueToCrop = stringParagraph.Substring(total).Trim();
                total = total + stringParagraph.Substring(total).Length - valueToCrop.Length;

                begin = total;
            }

            //return GetParagraphs(final);
            return result.ToArray();
        }
    }
}
