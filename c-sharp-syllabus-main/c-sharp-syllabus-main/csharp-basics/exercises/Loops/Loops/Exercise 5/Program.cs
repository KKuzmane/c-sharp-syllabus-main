using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first word: ");
            string firstWord = Console.ReadLine();
            Console.WriteLine("Enter your second word: ");
            string secondWord = Console.ReadLine();
            int numOfChars = 30;
            int firstLength = firstWord.Length;
            int secondLength = secondWord.Length;
            int dotCount = numOfChars - firstLength - secondLength;

            Console.Write(firstWord);
            for(int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
            }
            Console.Write(secondWord);

            Console.ReadKey();
        }
    }
}