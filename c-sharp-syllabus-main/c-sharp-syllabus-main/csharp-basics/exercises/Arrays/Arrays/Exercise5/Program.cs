using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            int element36 = 36;
            int element29 = 29;
            int indexOfElement36 = Array.IndexOf(myArray, element36);
            var indexOfElement29 = Array.IndexOf(myArray, element29);
        
            Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            Console.WriteLine("Index position of 29 is: " + indexOfElement29);

            Console.ReadKey();
        }
    }
}
