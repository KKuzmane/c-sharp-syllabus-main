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
            double overtimeMultiplyer = 1.5;
            double requiredHours = 40;
            double maxHoursPerWeek = 60;
            double minSalary = 8.0;
            double overtimeHours = 0;
            string[] emp1 = { "Employee1", "Employee2", "Employee3"};
            double[] base1 = { 7.5, 8.2, 10 };
            double[] hours1 = { 35, 47, 73 };
            double salary;
            double hours;

            for (int index = 0; index < emp1.Count(); index++)
            {
                if (base1[index] < minSalary)
                {
                    Console.WriteLine("error");
                }
                else if (hours1[index] > maxHoursPerWeek)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (hours1[index] > requiredHours)
                    {
                        overtimeHours = hours1[index] - requiredHours;
                    }
                    if (hours1[index] < requiredHours)
                    {
                        hours = hours1[index];
                    }
                    else
                    {
                        hours = requiredHours;
                    }
                    salary = Math.Round((base1[index] * hours) + (overtimeMultiplyer * overtimeHours * base1[index]), 2);
                    Console.WriteLine(emp1[index] + " has worked " + hours1[index] + " hours for " + base1[index] + " dollars in an hour. His salary " +
                        "this week is " + salary + " dollars");
                }
            }

            Console.ReadKey();
        }
    }
}
