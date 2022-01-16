using Exercise_5;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace Exercise5.Tests
{
    public class Exercise5Tests
    {
        private Date _target;
        private Date _targetWithValues;
        [SetUp]
        public void Setup()
        {
            _target = new Date(0,0,0);
            _targetWithValues = new Date(21, 5, 1995);
        }

        [Test]
        public void Month_Input5_Returns5()
        {
            // Act
            int month = _target.Month(5);

            // Assert
            Assert.AreEqual(5, month);
        }

        [Test]
        public void Day_Input21_Return21()
        {
            // Act
            int day = _target.Day(21);

            // Assert
            Assert.AreEqual(21, day);
        }

        [Test]
        public void Year_Input1995_Return1995()
        {
            // Act
            int year = _target.Year(1995);

            // Assert
            Assert.AreEqual(1995, year);
        }

        [Test]
        public void DisplayDate_ReturnsStringDate()
        {
            // Act
            string day = _targetWithValues.DisplayDate();
            string expected = "21/5/1995";

            // Assert
            Assert.AreEqual(expected, day);
        }
    }
}