using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList colors = new ArrayList();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine(" ");
            Console.WriteLine("New list:");
            Console.WriteLine(" ");

            colors.Insert(0, "Pink");
            colors.Insert(2, "Blue");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}