using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
                average = Math.Round(sum / number, 2);

                Console.WriteLine("The average is " + average);
                Console.WriteLine("The sum of " + lowerBound + " to " + upperBound + " is " + sum);
            }
        }
    }
}
