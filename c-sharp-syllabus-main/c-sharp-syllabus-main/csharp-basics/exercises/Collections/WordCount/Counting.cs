using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    public class Counting
    {
        public int Words(string text)
        {
            var wordList = Regex.Matches(text, @"\w+").Cast<Match>().Select(x => x.Value).ToList();
            int wordCount = wordList.Count;

            return wordCount;
        }

        public int Lines(string[] lines)
        {
            var lineCount = lines.Length;

            return lineCount;
        }

        public int Chars(string[] lines)
        {
            int charCount = lines.Sum(s => s.Length);
            
            return charCount;
        }
    }
}