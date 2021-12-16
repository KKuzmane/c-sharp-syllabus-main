using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            List<List<string>> histogram = new List<List<string>>();

            List<string> counter00 = new List<string>();
            counter00.Add("00-09: ");
            List<string> counter10 = new List<string>();
            counter10.Add("10-19: ");
            List<string> counter20 = new List<string>();
            counter20.Add("20-29: ");
            List<string> counter30 = new List<string>();
            counter30.Add("30-39: ");
            List<string> counter40 = new List<string>();
            counter40.Add("40-49: ");
            List<string> counter50 = new List<string>();
            counter50.Add("50-59: ");
            List<string> counter60 = new List<string>();
            counter60.Add("60-69: ");
            List<string> counter70 = new List<string>();
            counter70.Add("70-79: ");
            List<string> counter80 = new List<string>();
            counter80.Add("80-89: ");
            List<string> counter90 = new List<string>();
            counter90.Add("90-99: ");
            List<string> counter100 = new List<string>();
            counter100.Add("  100: ");

            foreach (var s in readText)
            {
                string[] lines = s.Split(' ');
                foreach (string line in lines)
                {
                    int score = Convert.ToInt32(line);
                    if (score < 10)
                    {
                        counter00.Add("*");
                    }
                    else if (score < 20 && score >= 10)
                    {
                        counter10.Add("*");
                    }
                    else if (score < 30 && score >= 20)
                    {
                        counter20.Add("*");
                    }
                    else if (score < 40 && score >= 30)
                    {
                        counter30.Add("*");
                    }
                    else if (score < 50 && score >= 40)
                    {
                        counter40.Add("*");
                    }
                    else if (score < 60 && score >= 50)
                    {
                        counter50.Add("*");
                    }
                    else if (score < 70 && score >= 60)
                    {
                        counter60.Add("*");
                    }
                    else if (score < 80 && score >= 70)
                    {
                        counter70.Add("*");
                    }
                    else if (score < 90 && score >= 80)
                    {
                        counter80.Add("*");
                    }
                    else if (score < 100 && score >= 90)
                    {
                        counter90.Add("*");
                    }
                    else
                    {
                        counter100.Add("*");
                    }
                }
            }

            histogram.Add(counter00);
            histogram.Add(counter10);
            histogram.Add(counter20);
            histogram.Add(counter30);
            histogram.Add(counter40);
            histogram.Add(counter50);
            histogram.Add(counter60);
            histogram.Add(counter70);
            histogram.Add(counter80);
            histogram.Add(counter90);
            histogram.Add(counter100);

            foreach (var lists in histogram)
            {
                foreach (var list in lists)
                {
                    Console.Write(list);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
