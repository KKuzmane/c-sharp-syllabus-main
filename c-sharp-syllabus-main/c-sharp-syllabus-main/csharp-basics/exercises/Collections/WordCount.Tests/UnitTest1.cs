using NUnit.Framework;

namespace WordCount.Tests
{
    public class Tests
    {
        private Counting _target;
        [SetUp]
        public void Setup()
        {
            _target = new Counting();
        }

        [Test]
        public void Words_NewString_ShouldReturn11()
        {
            // Arrange
            string newStringWords = "Life is what happens when you’re busy making other plans.";

            // Act
            int count = _target.Words(newStringWords);

            // Assert
            Assert.AreEqual(11, count);
        }

        [Test]
        public void Char_NewString_ShouldReturn28()
        {
            // Arrange
            string newString = "Get busy living or get busy dying.";
            string[] newChars = newString.Split();

            // Act
            int count = _target.Chars(newChars);

            // Assert
            Assert.AreEqual(28, count);
        }

        [Test]
        public void Lines_NewString_ShouldReturn3()
        {
            // Arrange
            string newString = "Never let the fear of \nstriking out keep you \nfrom playing the game.";
            string[] newLines = newString.Split('\n');

            // Act
            int count = _target.Lines(newLines);

            // Assert
            Assert.AreEqual(3, count);
        }
    }
}