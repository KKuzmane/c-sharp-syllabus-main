using CheckOddEven;
using NUnit.Framework;

namespace ArithmeticTask2.Tests
{
    public class ArithmeticTask2Tests
    {
        private CheckOddEven.OddOrEven _target;
        [SetUp]
        public void Setup()
        {
            _target = new OddOrEven();
        }

        [Test]
        public void CheckIfOddOrEven_Input3_ReturnsOddNumber()
        {
            // Act
            string isOdd = _target.CheckIfOddOrEven(3);

            // Assert
            Assert.AreEqual("Odd Number", isOdd);
        }

        [Test]
        public void CheckIfOddOrEven_Input10_ReturnsEvenNumber()
        {
            // Act
            string isEven = _target.CheckIfOddOrEven(10);

            // Assert
            Assert.AreEqual("Even Number", isEven);
        }
    }
}