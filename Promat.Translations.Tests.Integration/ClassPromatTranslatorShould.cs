using FluentAssertions;
using NUnit.Framework;
using Promat.Translations.Constants;
using Promat.Translations.Models;
using System;
using System.Threading.Tasks;

namespace Promat.Translations.Tests.Integration
{
    public class ClassPromatTranslatorShould : BaseIntegrationTest
    {
        [Test]
        public async Task CanTranslateSomeTexts()
        {
            var translatedTexts = await PromatTranslator.TranslateAsync(new[] { Repository.GetWord("es"), Repository.GetWord2("es") }, Languages.Ingles);

            translatedTexts[0].Should().Be(Repository.GetWord("en"));
            translatedTexts[1].Should().Be(Repository.GetWord2("en"));
        }

        [Test]
        public async Task CanTranslateListOfTextsAllLanguages()
        {
            var languages = (Languages[])Enum.GetValues(typeof(Languages));
            var aTraducir = new[] {
                "Sistema API para el tratamiento de información",
                "Posibilidad de importar de importar múltiples documentos \"personalizados\" por usuario",
                "Añadida la información necesaria para el proceso empresarial",
                "Nuevo comportamiento del condensador de fluzo."
            };

            var manager = new TranslationManager(aTraducir, languages);
            var result = await manager.TranslateAsync();
            result.Should().HaveCount(aTraducir.Length);
            result.ForEach(t => t.Should().HaveCount(languages.Length));
        }

        [Test]
        public async Task CanTranslateListOfTexts()
        {
            var newsList = Repository.GetNewsList();
            var num = newsList.Count;

            var results = await PromatTranslator.TranslateAsync(newsList, Languages.Ingles);

            results.Count.Should().Be(num);
        }

        [Test]
        public async Task CanNotificateProgressOfTranslation()
        {
            await PromatTranslator.TranslateAsync(Repository.Get4000CharactersInSomeParagraphs("es").Split(Environment.NewLine), Languages.Ingles,
                                                  tuple =>
                                                  {
                                                      (tuple.currentTranslation <= tuple.totalTranslations).Should().BeTrue();
                                                  });
        }

        [Test]
        public async Task CanTranslateSomeTexts2()
        {
            await PromatTranslator.TranslateAsync(Repository.GetRealProblematicIn20190627List(),
                                                  Languages.Ingles,
                                                  tuple =>
                                                  {
                                                      (tuple.currentTranslation <= tuple.totalTranslations).Should().BeTrue();
                                                  });
        }
    }
}