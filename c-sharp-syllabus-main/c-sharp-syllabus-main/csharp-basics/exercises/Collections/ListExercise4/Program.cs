using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            ArrayList colors = new ArrayList()
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            string element = colors[0].ToString();
            Console.WriteLine("First element: " + element);

            element = colors[2].ToString(); ;
            Console.WriteLine("Third element: " + element);

            Console.ReadKey();
        }
    }
}