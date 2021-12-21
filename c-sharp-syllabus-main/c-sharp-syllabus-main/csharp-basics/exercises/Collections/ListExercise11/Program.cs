using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");
            list.Add("six");
            list.Add("seven");
            list.Add("eight");
            list.Add("nine");
            list.Add("zero");

            list[4] = "hello!";

            int indexLast = list.Count - 1;

            list[indexLast] = "Bye!";

            list.Sort();

            Console.WriteLine("list contains Foobar: " + list.Contains("Foobar"));

            foreach(string element in list)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}