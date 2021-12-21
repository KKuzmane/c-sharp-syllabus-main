using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First List");
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            foreach(string color in firstList)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Second List");

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            foreach (string color in secondList)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("Joined List");

            firstList.AddRange(secondList);

            foreach (string color in firstList)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}