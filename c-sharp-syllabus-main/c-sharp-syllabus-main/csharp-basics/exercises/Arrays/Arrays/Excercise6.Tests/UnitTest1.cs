using System;
using Exercise_6;
using NUnit.Framework;

namespace Excercise6.Tests
{
    public class Excercise6Tests
    {
        private RandomArray _target;

        [SetUp]
        public void Setup()
        {
            _target = new RandomArray();
        }

        [Test]
        public void RandomNums_HasToReturnTenNumbers()
        {
            // Act
            var createArray = _target.RandomNumbers();

            // Assert
            Assert.AreEqual(createArray.Length, 10);
        }

        [Test]
        public void RandomNums_LastNumberIsChanged()
        {
            // Arrange
            var createArray = _target.RandomNumbers();

            // Act
            var createSecondArray = _target.RandomNumberCopy(_target.RandomNumbers());

            // Assert
            Assert.AreNotEqual(createArray, createSecondArray);
        }
    }
}