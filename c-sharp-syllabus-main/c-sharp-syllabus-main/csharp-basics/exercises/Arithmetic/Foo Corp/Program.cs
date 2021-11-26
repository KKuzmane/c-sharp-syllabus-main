using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo_Corp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hourlySalary = 8.00;
            double overtimeMultiplyer = 1.5;
            double requiredHours = 40;
            double maxHoursPerWeek = 60;
            Console.WriteLine("Enter yor hours here: ");
            string workedHoursInput = Console.ReadLine();
            double workedHours = Convert.ToDouble(workedHoursInput);
            double employeesSalary;
            if (workedHours > maxHoursPerWeek)
            {
                workedHours = maxHoursPerWeek;
                Console.WriteLine("You have worked more then we allow, so we will count only 60 hours in your paycheck.");
            }
            double overtimeHours = workedHours - requiredHours;

            employeesSalary = Math.Round((requiredHours * hourlySalary) + (overtimeHours * (hourlySalary * overtimeMultiplyer)), 2);

            Console.WriteLine("This week you have worked " + workedHours + " hours and there where " + overtimeHours + " overtime hours, so your salary this week is " +
                employeesSalary + " dollars.");
            Console.ReadKey();
        }
    }
}
