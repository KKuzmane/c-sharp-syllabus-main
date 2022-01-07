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
        public void Check_NumberIsOdd()
        {
            string isOdd = _target.CheckIfOddOrEven(3);

            Assert.AreEqual("Odd Number", isOdd);
        }

        [Test]
        public void Check_NumberIsEven()
        {
            string isEven = _target.CheckIfOddOrEven(10);

            Assert.AreEqual("Even Number", isEven);
        }
    }
}