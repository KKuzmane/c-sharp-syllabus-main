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
            var text = new CozaLozaWoza().CreateArrays(110);

            for (int i = 0; i < text.Count; i++)
            {
                Console.Write(text[i] + " ");

                if ((i+1) % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
