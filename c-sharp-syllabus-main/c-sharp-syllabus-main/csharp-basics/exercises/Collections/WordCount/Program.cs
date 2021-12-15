using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int charCount;
            int wordCount;
            int lineCount;

            string fileText = File.ReadAllText("../../lear.txt");

            charCount = File.ReadAllLines("../../lear.txt").Sum(s => s.Length);
            wordCount = Regex.Matches(fileText, @"\b\w+\b").Count;
            lineCount = File.ReadLines("../../lear.txt").Count();

            Console.WriteLine("Chars = " + charCount);
            Console.WriteLine("Words = " + wordCount);
            Console.WriteLine("Lines = " + lineCount);

            Console.ReadKey();
        }
    }
}