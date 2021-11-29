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
            int j = 1;
            
            while (j <= 110)
            { 
                for (int i = 1; i<= 1; i++)
                {
                    if ((j % 3 == 0) && (j % 5 == 0) && (j % 7 == 0))
                    {
                        Console.Write("CozaLozaWoza ");
                    }
                    else if ((j % 3 == 0) && (j % 5 == 0))
                    {
                        Console.Write("CozaLoza ");
                    }
                    else if ((j % 5 == 0) && (j % 7 == 0))
                    {
                        Console.Write("LozaWoza ");
                    }
                    else if ((j % 3 == 0) && (j % 7 == 0))
                    {
                        Console.Write("CozaWoza ");
                    }
                    else if (j % 3 == 0)
                    {
                        Console.Write("Coza ");
                    }
                    else if (j % 5 == 0)
                    {
                        Console.Write("Loza ");
                    }
                    else if (j % 7 == 0)
                    {
                        Console.Write("Woza ");
                    }
                    else Console.Write(j + " ");
                }
                if (j % 11 == 0)
                {
                    Console.WriteLine();
                }
                j++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
