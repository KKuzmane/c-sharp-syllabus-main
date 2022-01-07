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
        public void CalculateFinalPosition_TimeIs10()
        {
            int seconds = 10;

            var finalPosition = _target.GravityCalculator(seconds);

            Assert.AreEqual( -490.5, finalPosition);
        }

        [Test]
        public void CalculateFinalPosition_TimeIs6()
        {
            int seconds = 6;

            var finalPosition = _target.GravityCalculator(seconds);

            Assert.AreEqual(-176.58, finalPosition);
        }
    }
}