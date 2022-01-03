using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Person student1 = new Student("Klaus", "Shmit", "Ziedu 3", 2543, 9.8);
            Person student2 = new Student("Ralfs", "Haufmanis", "Lapu iel 63", 9961, 6.3);
            Person employee1 = new Employee("Laura", "Kupce", "Palmu 7", 3334, "Driver");
            Person employee2 = new Employee("Gustavs", "Ronis", "Riekstu iela 8", 6548, "Optometrist");

            list.Add(student1);
            list.Add(student2);
            list.Add(employee1);
            list.Add(employee2);

            foreach (Person person in list)
            {
                person.Display();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
