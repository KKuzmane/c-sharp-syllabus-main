using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Max? ");
            int max = int.Parse(Console.ReadLine()) + 1;
            int length = max - min;
            int[] arr = new int[length];

            for(int i = 0; i < length; i++)
            {
                arr[i] = i + min;
            }

            for(int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                int n = arr[0];
                arr = arr.ToList().Skip(1).ToArray();
                arr = arr.Concat(new int[] { n }).ToArray();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}