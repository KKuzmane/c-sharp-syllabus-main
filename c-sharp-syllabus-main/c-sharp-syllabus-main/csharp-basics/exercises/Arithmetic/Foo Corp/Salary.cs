using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Foo_Corp
{
    public class Salary
    {
        private string _employeeName;
        private double _base;
        private int _hours;

        public Salary(string employeeName, double basePay, int hours)
        {
            _employeeName = employeeName;
            _base = basePay;
            _hours = hours;
        }

        public string EmployeeName()
        {
            return _employeeName;
        }

        public double Base()
        {
            return _base;
        }

        public int Hours()
        {
            return _hours;
        }

        public bool CheckErrors(double minSalary, double maxHoursPerWeek)
        {
            if (_base < minSalary || _hours > maxHoursPerWeek)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculateSalary(double requiredHours, double overtimeMultiplyer)
        {
            double overtimeHours = 0;
            double hours = 0;
            
            if (_hours > requiredHours)
            {
                overtimeHours = _hours - requiredHours;
            }
            if (_hours < requiredHours)
            {
                hours = _hours;
            }
            else
            {
                hours = requiredHours;
            }
            double salary = Math.Round((_base * hours) + (overtimeMultiplyer * overtimeHours * _base), 2);

            return salary;
        }

    }
}
