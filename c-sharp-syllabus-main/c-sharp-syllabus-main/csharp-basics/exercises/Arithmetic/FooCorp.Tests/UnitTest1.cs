using Foo_Corp;
using NUnit.Framework;

namespace FooCorp.Tests
{
    public class FooCorpTests
    {
        private Salary _target1;
        private Salary _target2;
        private Salary _target3;
        private Salary _target4;
        private Salary _target5;
        private double _minSalary = 8;
        private double _maxHoursPerWeek = 60;
        double _requiredHours = 40;
        private double _overtimeMultiplyer = 1.5;

        [SetUp]
        public void Setup()
        {
            _target1 = new Salary("Employee1", 7.5, 35);
            _target2 = new Salary("Employee2", 8.2, 47);
            _target3 = new Salary("Employee3", 10, 73);
            _target4 = new Salary("Employee4", 8.0, 45);
            _target5 = new Salary("Employee5", 9, 0);
        }

        [Test]
        public void CheckErrors_MinSalaryAnsMaxHoursPerWeek_ExpectTrue()
        {
            // Act
            bool areErrors = _target3.CheckErrors(_minSalary, _maxHoursPerWeek);

            // Assert
            Assert.AreEqual(true, areErrors);
        }

        [Test]
        public void CheckErrors_MinSalaryMaxHoursPerWeek_ExpectedTrue()
        {
            // Act
            bool areErrors = _target1.CheckErrors(_minSalary, _maxHoursPerWeek);

            // Assert
            Assert.AreEqual(true, areErrors);
        }

        [Test]
        public void CheckErrors_MinSalaryMaxHoursPerWeek_ExpectedFalse()
        {
            // Act
            bool areErrors = _target2.CheckErrors(_minSalary, _maxHoursPerWeek);

            // Assert
            Assert.AreEqual(false, areErrors);
        }

        [Test]
        public void CalculateSalary_RequiredHoursOvertimeMultiplyer_Expected414Point1()
        {
            // Act
            double calculateSalary = _target2.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            // Assert
            Assert.AreEqual(414.1, calculateSalary);
        }

        public void CalculateSalary_RequiredHoursOvertimeMultiplyer_ExpectedErrorMessage()
        {
            // Act
            double calculateSalary = _target1.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            // Assert
            Assert.AreNotEqual("", calculateSalary);
        }

        public void CalculateSalary_RequiredHoursOvertimeMultiplyer_Expect380()
        {
            // Act
            double calculateSalary = _target4.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            // Assert
            Assert.AreEqual(380, calculateSalary);
        }

        public void CalculateSalary_RequiredHoursOvertimeMultiplyer_Expected0()
        {
            // Act
            double calculateSalary = _target5.CalculateSalary(_requiredHours, _overtimeMultiplyer);
            
            // Assert
            Assert.AreEqual(0, calculateSalary);
        }
    }
}