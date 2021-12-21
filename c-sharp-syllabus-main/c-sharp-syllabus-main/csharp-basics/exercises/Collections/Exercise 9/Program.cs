using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Ralfs");
            names.Add("Oskars");
            names.Add("Laima");
            names.Add("Maija");
            names.Add("Anna");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("New list: ");

            names.Clear();

            names.Add("Ralfs");
            names.Add("Ralfs");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
