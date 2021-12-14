using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Black");
            colors.Add("Orange");
            colors.Add("Pink");
            colors.Add("White");

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}