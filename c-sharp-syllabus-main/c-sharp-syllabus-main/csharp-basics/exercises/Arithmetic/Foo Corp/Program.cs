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
            double minSalary = 8.0;
            double requiredHours = 40;
            double maxHoursPerWeek = 60;
            double overtimeMultiplyer = 1.5;

            List<Salary> employees = new List<Salary>();
            employees.Add(new Salary("Employee1", 7.5, 35));
            employees.Add(new Salary("Employee2", 8.2, 47));
            employees.Add(new Salary("Employee3", 10, 73));

            foreach (var employee in employees)
            {
                if (employee.CheckErrors(minSalary, maxHoursPerWeek) == true)
                {
                    Console.WriteLine("error");
                    continue;
                }

                double salary = employee.CalculateSalary(requiredHours, overtimeMultiplyer);

                Console.WriteLine(employee.EmployeeName() + " has worked " + employee.Hours() + " hours for " + employee.Base() + " dollars in an hour. His salary " + "this week is " + salary + " dollars");

            }
            Console.ReadKey();
        }
    }
}
