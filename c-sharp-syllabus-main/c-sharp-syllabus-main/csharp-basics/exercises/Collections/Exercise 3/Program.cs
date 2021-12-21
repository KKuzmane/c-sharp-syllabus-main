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
            List<string> names = new List<string>();

            string name = " ";

            while(name != "")
            {
                Console.WriteLine("Enter new name: ");
                name = Console.ReadLine();

                names.Add(name);
            }

            List<string> uniqueNames = names.Distinct().ToList(); 

            foreach(string word in uniqueNames)
            {
                Console.Write(word + " ");
            }

            Console.ReadKey();
        }
    }
}