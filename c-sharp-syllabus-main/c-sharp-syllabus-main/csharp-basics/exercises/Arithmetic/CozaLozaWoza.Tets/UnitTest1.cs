using NUnit.Framework;

namespace CozaLozaWoza.Tets
{
    public class CozaLozaWozaTests
    {
        private CozaLozaWoza _target;
        [SetUp]
        public void Setup()
        {
            _target = new CozaLozaWoza();
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs69_ReturnCoza()
        {
            int a = 69;
            string expectedOutput = "Coza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a-1]);
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs10_ReturnLoza()
        {
            int a = 10;
            string expectedOutput = "Loza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs49_ReturnWoza()
        {
            int a = 49;
            string expectedOutput = "Woza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs10_ReturnCozaLoza()
        {
            int a = 15;
            string expectedOutput = "CozaLoza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs10_ReturnCozaWoza()
        {
            int a = 21;
            string expectedOutput = "CozaWoza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs10_ReturnLozaWoza()
        {
            int a = 70;
            string expectedOutput = "LozaWoza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateCozaLozaWoza_NumberIs10_ReturnCozaLozaWoza()
        {
            int a = 105;
            string expectedOutput = "CozaLozaWoza";

            var b = _target.CreateArrays(110);

            Assert.AreEqual(expectedOutput, b[a - 1]);
        }
    }
}