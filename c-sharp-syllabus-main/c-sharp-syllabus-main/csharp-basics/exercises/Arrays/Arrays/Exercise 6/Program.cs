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
            int min = 1;
            int max = 100;
            int a = -7;
            int[] randomNums = new int[10];
            Random number = new Random();

            Console.Write("Array 1: ");

            for (int i = 0; i < randomNums.Length; i++ )
            {
                randomNums[i] = number.Next( min, max );
            }

            for(int j = 0; j<randomNums.Length; j++)
            {
                if(j == randomNums.Length-1)
                {
                    Console.Write(a);
                }
                else
                {
                    Console.Write(randomNums[j] + " ");
                }
            }

            int[] newRandomNums = new int[10];

            randomNums.CopyTo(newRandomNums, 0);

            Console.WriteLine();
            Console.Write("Array 2: ");

            foreach (var item in newRandomNums)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}