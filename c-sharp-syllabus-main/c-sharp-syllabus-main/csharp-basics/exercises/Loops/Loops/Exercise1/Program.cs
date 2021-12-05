using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int max = 10;
            Console.WriteLine("The first 10 natural numbers are: ");
            for( i = 0; i < max; i++)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();
        }
    }
}