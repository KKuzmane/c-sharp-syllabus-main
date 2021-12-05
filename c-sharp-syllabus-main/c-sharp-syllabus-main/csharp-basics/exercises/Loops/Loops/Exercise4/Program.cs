using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            Console.WriteLine("Enter your favorite quote: ");
            string input = Console.ReadLine().ToLower();
            char[] charArray = input.ToCharArray();

            Console.WriteLine("All vowels in you quote: ");
            for (int i = 0; i < input.Length; i++) 
            {
                if (charArray[i] == 'a' || charArray[i] == 'e' || charArray[i] == 'i' || charArray[i] == 'o' || charArray[i] == 'u')
                {
                    Console.Write(charArray[i] + " ");
                } 
            }

            Console.WriteLine();
            Console.WriteLine("All vowels in you quote: ");

            foreach (char ch in charArray) 
            {
                if (vowels.Contains(ch))
                {
                    Console.Write(ch + " ");
                }
            }
            Console.ReadKey();
        }
    }
}