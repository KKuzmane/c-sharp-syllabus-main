using NUnit.Framework;

namespace CalculateArea.Tests
{
    public class CalculateAreaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateCircleArea_Radius_Return43Point98()
        {
            // Arrange
            var radius = 7;

            // Act
            var area = CalculateArea.CalculateCircleArea(radius);

            // Assert
            Assert.AreEqual(43.98, area);
        }

        [Test]
        public void CalculateRectangleArea_LengthAndWidth_Return50()
        {
            // Arrange
            var length = 5;
            var width = 10;

            // Act
            var area = CalculateArea.CalculateRectangleArea(length, width);

            // Assert
            Assert.AreEqual(50, area);
        }

        [Test]
        public void CalculateTriangleArea_GroundHeight_Return36()
        {
            // Arrange
            var ground = 8;
            var height = 9;

            // Act
            var area = CalculateArea.CalculateTriangleArea(ground, height);

            // Assert
            Assert.AreEqual(36, area);
        }
    }
}