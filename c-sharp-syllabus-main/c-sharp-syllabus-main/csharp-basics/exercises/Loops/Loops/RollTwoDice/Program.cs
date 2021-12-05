using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTwoDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int sum = int.Parse(Console.ReadLine());
            int rolledSum = 0;

            while(rolledSum != sum)
            {
                Random randomNum = new Random();
                int dice1 = randomNum.Next(1, 7);
                int dice2 = randomNum.Next(1, 7);

                rolledSum = dice1 + dice2;
                Console.WriteLine($"{dice1} and {dice2} = {rolledSum}");
            }
            Console.ReadKey();
        }
    }
}
