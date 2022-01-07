using NUnit.Framework;
using Task_1;

namespace ArithmeticTask1.Tests
{
    public class ArithmeticTask1Test
    {
        private Task_1.IsItFifteen _target;
        [SetUp]
        public void Setup()
        {
            _target = new IsItFifteen();
        }

        [Test]
        public void CheckNumbers_IfAnyAreFifteen()
        {
            bool output = _target.IsFifteen(15, 9);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void CheckSum_IfNumberSumIsFifteen()
        {
            bool output = _target.IsFifteen(10, 5);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void CheckSum_IfSumIsNotFifteen()
        {
            bool output = _target.IsFifteen(18, 9);

            Assert.AreEqual(false, output);
        }

        [Test]
        public void CheckSubtraction_CheckIfXIsBigger()
        {
            bool output = _target.IsFifteen(20, 5);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void CheckSubtraction_CheckIfYIsBigger()
        {
            bool output = _target.IsFifteen(5, 20);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void CheckSubtraction_CheckIfSubtractionIsNotFifteen()
        {
            bool output = _target.IsFifteen(6, 30);

            Assert.AreEqual(false, output);
        }
    }
}