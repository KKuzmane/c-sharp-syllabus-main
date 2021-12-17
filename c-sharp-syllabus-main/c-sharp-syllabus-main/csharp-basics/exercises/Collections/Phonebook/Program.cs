using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();
            phoneDirectory.PutNumber("mans", "2356846");
            phoneDirectory.PutNumber("ert", "3252546");
            phoneDirectory.PutNumber("kg", "565858568");
            
            Console.WriteLine($"{phoneDirectory.GetNumber("kg")}");

            Console.ReadKey();
        }
    }
}