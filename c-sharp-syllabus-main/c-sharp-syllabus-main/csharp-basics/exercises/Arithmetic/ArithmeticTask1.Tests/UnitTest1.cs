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
        public void IsFifteen_Input15And9_ReturnsTrue()
        {
            // Act
            bool output = _target.IsFifteen(15, 9);

            // Assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void IsFifteen_Input10And5_ReturnsTrue()
        {
            // Act
            bool output = _target.IsFifteen(10, 5);

            // Assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void IsFifteen_Input18And9_ReturnsFalse()
        {
            // Act
            bool output = _target.IsFifteen(18, 9);

            // Assert
            Assert.AreEqual(false, output);
        }

        [Test]
        public void IsFifteen_Input20And5_ReturnsTrue()
        {
            // Act
            bool output = _target.IsFifteen(20, 5);

            // Assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void IsFifteen_Input5And20_ReturnsTrue()
        {
            // Act
            bool output = _target.IsFifteen(5, 20);

            // Assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void IsFifteen_Input6and30_ReturnsFalse()
        {
            // Act
            bool output = _target.IsFifteen(6, 30);

            // Assert
            Assert.AreEqual(false, output);
        }
    }
}