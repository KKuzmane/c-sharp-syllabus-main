using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();
            double firstSign = Convert.ToDouble(input);

            if (firstSign < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (firstSign > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
            Console.ReadKey();
        }
    }
}
