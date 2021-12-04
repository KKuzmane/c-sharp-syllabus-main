using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiFigure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of figure: ");
            int inputSize = int.Parse(Console.ReadLine());
            string s = "*";
            string c = "/";
            string d = @"\";
            int size = 0;

            for (int j = 1; j < inputSize; j++)
            {
                size += 8;
            }

            for (int i = 0; i < inputSize; i++)
            {
                int a = i * 8;
                int h = (size - a) / 2;
                for(int t = 0; t < h; t++)
                {
                    Console.Write(c);
                }
                for (int v = 0; v < a; v++)
                {
                    Console.Write(s);
                }
                for (int t = 0; t < h; t++)
                {
                    Console.Write(d);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
