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
        public void CreateArray_HasToBeTenNumbers()
        {
            var createArray = _target.RandomNumbers();

            Assert.AreEqual(createArray.Length, 10);
        }

        [Test]
        public void FirstArray_LastNumberIsChanged()
        {
            var createArray = _target.RandomNumbers();
            var createSecondArray = _target.RandomNumberCopy(_target.RandomNumbers());

            Assert.AreNotEqual(createArray, createSecondArray);
        }
    }
}