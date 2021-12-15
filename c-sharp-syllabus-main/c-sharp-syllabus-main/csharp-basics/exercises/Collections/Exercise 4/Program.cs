using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int res = number;

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(res);

            while(list.Count() == list.Distinct().Count())
            {
                int[] math = res.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

                res = 0;

                foreach(int digit in math)
                {
                    res += Convert.ToInt32(Math.Pow(digit, 2));
                }
                
                Console.WriteLine(res);
                list.Add(res);
            }

            if (res == 1)
            {
                Console.WriteLine(number + " is HAPPY number :) !");
            }
            else
            {
                Console.WriteLine(number + " is not a HAPPY number :( !");
            }

            Console.ReadKey();
        }
    }
}
