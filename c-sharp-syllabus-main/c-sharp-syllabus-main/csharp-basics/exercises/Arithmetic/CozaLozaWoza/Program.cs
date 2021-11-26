using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            
            while (number <= 110)
            { 
                for (int i = 1; i<= 1; i++)
                {
                    if ((number % 3 == 0) && (number % 5 == 0) && (number % 7 == 0))
                    {
                        Console.Write("CozaLozaWoza ");
                    }
                    else if ((number % 3 == 0) && (number % 5 == 0))
                        {
                        Console.Write("CozaLoza ");
                    }
                    else if ((number % 5 == 0) && (number % 7 == 0))
                        {
                        Console.Write("LozaWoza ");
                    }
                    else if ((number % 3 == 0) && (number % 7 == 0))
                    {
                        Console.Write("CozaWoza ");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.Write("Coza ");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.Write("Loza ");
                    }
                    else if (number % 7 == 0)
                    {
                        Console.Write("Woza ");
                    }
                    else Console.Write(number + " ");
                }
                if (number % 11 == 0)
                {
                    Console.WriteLine();
                }
                number++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
