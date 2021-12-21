using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.WriteLine("List before sort: ");
            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            List<string> sorted = colors.OrderBy(x => x).ToList();

            Console.WriteLine("List after sort: ");
            foreach (string color in sorted)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}