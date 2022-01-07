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
        public void Calculate_CircleArea_Radius7()
        {
            var radius = 7;
            var area = CalculateArea.CalculateCircleArea(radius);

            Assert.AreEqual(43.98, area);
        }

        [Test]
        public void Calculate_RectangleArea_Length5Width10()
        {
            var length = 5;
            var width = 10;
            var area = CalculateArea.CalculateRectangleArea(length, width);

            Assert.AreEqual(50, area);
        }

        [Test]
        public void Calculate_TriangleArea_Ground8Height9()
        {
            var ground = 8;
            var height = 9;
            var area = CalculateArea.CalculateTriangleArea(ground, height);

            Assert.AreEqual(36, area);
        }
    }
}