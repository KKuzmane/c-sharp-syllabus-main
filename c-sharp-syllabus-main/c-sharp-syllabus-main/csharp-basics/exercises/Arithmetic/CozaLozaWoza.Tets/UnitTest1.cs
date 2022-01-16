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
        public void CreateArrays_NumberIs69_ReturnCoza()
        {
            // Arrange
            int a = 69;
            string expectedOutput = "Coza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a-1]);
        }

        [Test]
        public void CreateArrays_NumberIs10_ReturnLoza()
        {
            // Arrange
            int a = 10;
            string expectedOutput = "Loza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateArrays_NumberIs49_ReturnWoza()
        {
            // Arrange
            int a = 49;
            string expectedOutput = "Woza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateArrays_NumberIs15_ReturnCozaLoza()
        {
            // Arrange
            int a = 15;
            string expectedOutput = "CozaLoza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateArrays_NumberIs21_ReturnCozaWoza()
        {
            // Arrange
            int a = 21;
            string expectedOutput = "CozaWoza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateArrays_NumberIs70_ReturnLozaWoza()
        {
            // Arrange
            int a = 70;
            string expectedOutput = "LozaWoza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a - 1]);
        }

        [Test]
        public void CreateArrays_NumberIs105_ReturnCozaLozaWoza()
        {
            // Arrange
            int a = 105;
            string expectedOutput = "CozaLozaWoza";

            // Act
            var b = _target.CreateArrays(110);

            // Assert
            Assert.AreEqual(expectedOutput, b[a - 1]);
        }
    }
}