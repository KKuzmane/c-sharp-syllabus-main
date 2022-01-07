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
        public void Check_IfWorkedMoreThanMaxHours()
        {
            bool areErrors = _target3.CheckErrors(_minSalary, _maxHoursPerWeek);

            Assert.AreEqual(true, areErrors);
        }

        [Test]
        public void Check_IfWorkedWithTooSmallBasePay()
        {
            bool areErrors = _target1.CheckErrors(_minSalary, _maxHoursPerWeek);

            Assert.AreEqual(true, areErrors);
        }

        [Test]
        public void Check_IfThereAreNoErrors()
        {
            bool areErrors = _target2.CheckErrors(_minSalary, _maxHoursPerWeek);

            Assert.AreEqual(false, areErrors);
        }

        [Test]
        public void Calculate_SalaryWithNoExtraHours()
        {
            double calculateSalary = _target2.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            Assert.AreEqual(414.1, calculateSalary);
        }

        public void Calculate_SalaryIfError()
        {
            double calculateSalary = _target1.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            Assert.AreNotEqual("", calculateSalary);
        }

        public void Calculate_SalaryWithExtraHours()
        {
            double calculateSalary = _target4.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            Assert.AreEqual(380, calculateSalary);
        }

        public void Calculate_SalaryWithZeroHours()
        {
            double calculateSalary = _target5.CalculateSalary(_requiredHours, _overtimeMultiplyer);

            Assert.AreEqual(0, calculateSalary);
        }
    }
}