using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using PromatTranslations.Constants;

namespace PromatTranslations.Tests.Unit
{
    public class ClassPromatTranslatorShould
    {
        [Test]
        public async Task GetAvailableTranslationLanguages()
        {
            var languagesTask = PromatTranslator.GetAvailableTranslationLanguages();
            var englishLanguagesTask = PromatTranslator.GetAvailableTranslationLanguages(Languages.Ingles);
            var languagesList = await languagesTask;
            var englishLanguagesList = await englishLanguagesTask;

            languagesList.Count.Should().Be(englishLanguagesList.Count);
            var inSpanish = languagesList.Single(x => x.languageCode == "es");
            var inEnglish = englishLanguagesList.Single(x => x.languageCode == "es");
            inSpanish.languageCode.Should().Be(inEnglish.languageCode);
            inSpanish.languageName.Should().NotBe(inEnglish.languageName);
        }
        [Test]
        public void ThrowExceptionWhenCallTranslateAsyncWithoutAnAzureApiKey()
        {
            Func<Task> translateAction = async () => await PromatTranslator.TranslateAsync("some text", Languages.Ingles);

            translateAction.Should().Throw<ArgumentException>();
        }
    }
}