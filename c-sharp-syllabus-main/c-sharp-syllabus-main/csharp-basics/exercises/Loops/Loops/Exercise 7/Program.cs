using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piglet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("Roll a dice by entering letter y!");
            char r = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int pointCounter = 0;
            while(r != 'y')
            {
                Console.WriteLine("Wrong input. If you want to roll the dice, enter 'y'.");
                r = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            while(r == 'y')
            {
                Random randomNum = new Random();
                int dice = randomNum.Next(1, 7);
                pointCounter += dice;
                if(dice == 1)
                {
                    Console.WriteLine($"You rolled {dice}. Game over. You got 0 points.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You rolled {dice}. Your current points are {pointCounter}. Play again y/n?");
                    r = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    while (r != 'y')
                    {
                        if(r == 'n')
                        {
                            Console.WriteLine($"You got {pointCounter} points.");
                            break;
                        }
                        Console.WriteLine("Wrong input. If you want to roll the dice, enter 'y'.");
                        r = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}