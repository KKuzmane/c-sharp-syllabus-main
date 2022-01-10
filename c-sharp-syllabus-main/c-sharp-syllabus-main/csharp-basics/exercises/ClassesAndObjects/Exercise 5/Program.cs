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
            Date date = new Date(0, 0, 0);

            Console.WriteLine("Input day");
            int d = int.Parse(Console.ReadLine());
            date.Day(d);
            Console.WriteLine("Input month");
            int m = int.Parse(Console.ReadLine());
            date.Month(m);
            Console.WriteLine("Input year");
            int y = int.Parse(Console.ReadLine());
            date.Year(y);

            Console.WriteLine(date.DisplayDate());

            Console.ReadKey();
        }
    }
}
