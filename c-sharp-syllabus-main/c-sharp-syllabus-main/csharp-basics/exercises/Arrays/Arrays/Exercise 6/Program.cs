using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Array 1: {new RandomArray().PrintFirstArray(new RandomArray().RandomNumbers())}");
            Console.WriteLine();
            Console.WriteLine($"Array 2: {new RandomArray().PrintSecondArray(new RandomArray().RandomNumberCopy((new RandomArray().RandomNumbers())))}");

            Console.ReadKey();
        }
    }
}