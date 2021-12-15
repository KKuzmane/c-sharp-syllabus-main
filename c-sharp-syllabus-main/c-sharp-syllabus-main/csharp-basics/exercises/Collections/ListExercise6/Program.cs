using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise6
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

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            } 

            colors.RemoveAt(2);

            Console.WriteLine("After removing third element from the list:");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}