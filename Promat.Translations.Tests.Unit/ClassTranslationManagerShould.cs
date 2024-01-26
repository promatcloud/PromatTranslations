using FluentAssertions;
using NUnit.Framework;
using Promat.Translations.Constants;
using Promat.Translations.Models;
using System.Linq;

namespace Promat.Translations.Tests.Unit
{
    public class ClassTranslationManagerShould
    {
        [Test]
        public void CanPrepareAndRecomposeText()
        {
            var novedadesList = Repository.GetNewsList();
            var num = novedadesList.Count;

            var manager = new TranslationManager(novedadesList, Languages.Ingles);
            var preparedText = manager.TestPrepareText();

            for (int i = 1; i <= num; i++)
            {
                preparedText.Any(t => t.Contains($"<mark>{i}</mark>")).Should().BeTrue();
            }

            var result = manager.TestRecomposedTranslatedTexts(Repository.GetNewsRawTranslation());
            result.Count.Should().Be(num);
        }
    }
}