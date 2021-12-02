using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNums = new int[10];
            Random number = new Random();
            int counter = 0;

            while (counter < 10)
            {
                int random = number.Next(1, 100);

                if(Array.IndexOf(randomNums, random) <= 0)
                {
                    randomNums[counter] = random;
                    counter++;
                }
            }

            for(int i = 0; i< 10; i++)
            {
                Console.Write(randomNums[i]);
            }

            int[] newArray = randomNums;
            Console.WriteLine(newArray);

            Console.ReadKey();
        }
    }
}
