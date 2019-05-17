using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using PromatTranslations.Constants;
using PromatTranslations.Models;

namespace PromatTranslations.Tests.Unit {
    public class ClassTranslationManagerShould
    {
        [Test]
        public void CanPrepareAndRecomposeText()
        {
            var novedadesList = Repository.GetNewsList();
            var num = novedadesList.Count;

            var manager = new TranslationManager(novedadesList, Languages.Ingles);
            var preparedText = manager.TestPrepateText();

            for (int i = 1; i <= num; i++)
            {
                preparedText.Any(t => t.Contains($"|{i}|")).Should().BeTrue();
            }

            var result = manager.TestRecomposedTranslatedTexts(Repository.GetNewsRawTranslation());
            result.Count.Should().Be(num);
        }
    }
}