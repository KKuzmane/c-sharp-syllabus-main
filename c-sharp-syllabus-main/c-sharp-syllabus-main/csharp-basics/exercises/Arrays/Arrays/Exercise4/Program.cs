using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };
            Console.WriteLine("Write a 4-digit number: ");
            int number = int.Parse(Console.ReadLine());

            if (myArray.Contains(number))
            {
            Console.WriteLine("Contains!");
            }
            else
            {
                Console.WriteLine("Not contain!");
            }
            Console.ReadKey();
        }
    }
}
