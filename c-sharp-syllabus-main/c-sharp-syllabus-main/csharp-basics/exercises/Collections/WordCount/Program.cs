using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileText = File.ReadAllText("../../lear.txt");
            string[] lines = File.ReadAllLines("../../lear.txt");
            
            int charCount = new Counting().Chars(lines);
            Console.WriteLine("Chars = " + charCount);
            int wordCount = new Counting().Words(fileText);
            Console.WriteLine("Words = " + wordCount);
            int lineCount = new Counting().Lines(lines);
            Console.WriteLine("Lines = " + lineCount);

            Console.ReadKey();
        }
    }
}