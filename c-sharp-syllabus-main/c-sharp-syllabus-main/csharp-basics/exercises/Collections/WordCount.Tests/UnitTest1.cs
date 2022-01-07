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
        public void Count_WordCount()
        {
            string newStringWords = "Life is what happens when you’re busy making other plans.";
            int count = _target.Words(newStringWords);

            Assert.AreEqual(11, count);
        }

        [Test]
        public void Count_CharCount()
        {
            string newString = "Get busy living or get busy dying.";
            string[] newChars = newString.Split();
            int count = _target.Chars(newChars);

            Assert.AreEqual(28, count);
        }

        [Test]
        public void Count_LineCount()
        {
            string newString = "Never let the fear of \nstriking out keep you \nfrom playing the game.";
            string[] newLines = newString.Split('\n');
            int count = _target.Lines(newLines);

            Assert.AreEqual(3, count);
        }
    }
}