using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minRange = 1;
            int maxRange = 2;
            Console.WriteLine("Guess the number between " + minRange + " and " + maxRange + ". Enter your guess here: ");
            string xInput = Console.ReadLine();
            int x = Convert.ToInt32(xInput);

            Random number = new Random();
            int numberRange = number.Next(minRange, maxRange);

            if(x == numberRange)
            {
                Console.WriteLine("Congratulations, your guess was correct!");
            }
            else
            {
                Console.WriteLine("Unfortunately your guess was wrong. Right number was " + numberRange + ". :( Better luck next time!");
            }
            Console.ReadKey();
        }
    }
}
