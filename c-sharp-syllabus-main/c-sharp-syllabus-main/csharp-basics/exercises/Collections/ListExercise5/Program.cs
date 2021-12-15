using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>
            {
                "Red",
                "Green",
                "Violet",
                "White",
                "Black"
            };

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine("_____New list_____");

            colors[2] = "Yellow";

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
