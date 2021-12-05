using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 500;
            int[] random = new int[20];
            Random num = new Random();

            Console.WriteLine("Insert a number from 1 to 20 to choose position of number in array: ");
            int position = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Your array is: ");
            for(int i = 0; i < random.Length; i++)
            {
                random[i] = num.Next(min, max);
                Console.Write(random[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Your number is {random[position]}");

            Console.ReadKey();
        }
    }
}
