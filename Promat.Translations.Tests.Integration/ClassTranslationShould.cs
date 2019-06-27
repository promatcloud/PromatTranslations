using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using Promat.Translations.Constants;
using Promat.Translations.Models;

namespace Promat.Translations.Tests.Integration
{
    public class ClassTranslationShould: BaseIntegrationTest
    {
        [Test]
        public async Task CanTranslateAWord()
        {
            var translation = new Translation(Repository.GetWord("es"), Languages.Ingles);
            var translatedText = await translation.TranslateAsync();
            var translatedText2 = await PromatTranslator.TranslateAsync(Repository.GetWord("es"), Languages.Ingles);

            translatedText.Single().Text.Should().Be(Repository.GetWord("en"));
            translatedText2.Should().Be(translatedText.Single().Text);
        }

        [Test]
        public async Task CanTranslateParraph()
        {
            var translation = new Translation(Repository.GetParagraph("es"), Languages.Ingles);
            var translatedText = await translation.TranslateAsync();

            translatedText.Single().Text.Should().Be(Repository.GetParagraph("en"));
        }

        [Test]
        public async Task CanTranslateAWordToMultipleLanguages()
        {
            var translation = new Translation(Repository.GetWord("es"), Languages.Ingles, Languages.Frances, Languages.Italiano, Languages.Portugues);
            var result = await translation.TranslateAsync();
            var languagesCodes = new[] { "en", "fr", "it", "pt" };

            foreach (var lang in languagesCodes)
            {
                var repositoryText = Repository.GetWord(lang);
                var translatedText = result.Single(info => info.Language == lang).Text;
                repositoryText.Equals(translatedText, StringComparison.InvariantCultureIgnoreCase).Should()
                        .BeTrue($"This texts should be equals for language '{lang}':{Environment.NewLine}Repository Text:{Environment.NewLine}{repositoryText}{Environment.NewLine}Translated Text:{Environment.NewLine}{translatedText}{Environment.NewLine}");
            }
        }

        [Test]
        public async Task CanTranslateParraphToMultipleLanguages()
        {
            var translation = new Translation(Repository.GetParagraph("es"), Languages.Ingles, Languages.Frances, Languages.Italiano, Languages.Portugues);
            var result = await translation.TranslateAsync();
            var languagesCodes = new[] { "en", "fr", "it", "pt" };

            foreach (var lang in languagesCodes)
            {
                var repositoryText = Repository.GetParagraph(lang);
                var translatedText = result.Single(info => info.Language == lang).Text;
                repositoryText.Equals(translatedText, StringComparison.InvariantCultureIgnoreCase).Should()
                        .BeTrue($"This texts should be equals for language '{lang}':{Environment.NewLine}Repository Text:{Environment.NewLine}{repositoryText}{Environment.NewLine}Translated Text:{Environment.NewLine}{translatedText}{Environment.NewLine}");
            }
        }

        [Test]
        public async Task CanTranslateLongParraphToMultipleLanguages()
        {
            var translation = new Translation(Repository.Get4000CharactersInSomeParagraphs("es"), Languages.Ingles, Languages.Frances, Languages.Italiano, Languages.Portugues);
            var result = await translation.TranslateAsync();
            var languagesCodes = new[] { "en", "fr", "it", "pt" };

            foreach (var lang in languagesCodes)
            {
                var repositoryText = Repository.Get4000CharactersInSomeParagraphs(lang);
                var translatedText = result.Single(info => info.Language == lang).Text;
                repositoryText.Equals(translatedText, StringComparison.InvariantCultureIgnoreCase).Should()
                        .BeTrue($"This texts should be equals for language '{lang}':{Environment.NewLine}Repository Text:{Environment.NewLine}{repositoryText}{Environment.NewLine}Translated Text:{Environment.NewLine}{translatedText}{Environment.NewLine}");
            }
        }
    }
}