
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 6;
            var finalPosition = new Calculations().GravityCalculator(seconds);
            
            Console.WriteLine("The object's position after " + seconds + " seconds is " + finalPosition + " m.");

            Console.ReadKey();
        }
    }
}
