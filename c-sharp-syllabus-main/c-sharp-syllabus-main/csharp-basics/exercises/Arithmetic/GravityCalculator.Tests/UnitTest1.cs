using NUnit.Framework;

namespace GravityCalculator.Tests
{
    public class GravityCalculatorTests
    {
        private GravityCalculator.Calculations _target;
        [SetUp]
        public void Setup()
        {
            _target = new GravityCalculator.Calculations();
        }

        [Test]
        public void GravityCalculator_TimeIs10Seconds_ExpectNegative480Point5()
        {
            // Arrange
            int seconds = 10;

            // Act
            var finalPosition = _target.GravityCalculator(seconds);

            // Assert
            Assert.AreEqual( -490.5, finalPosition);
        }

        [Test]
        public void GravityCalculator_TimeIs6Seconds_ExpectNegative176point58()
        {
            // Arrange
            int seconds = 6;

            // Act
            var finalPosition = _target.GravityCalculator(seconds);

            // Assert
            Assert.AreEqual(-176.58, finalPosition);
        }
    }
}