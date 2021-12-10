using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwapPoints p1 = new SwapPoints(5, 2);
            SwapPoints p2 = new SwapPoints(-3, 6);

            Swapping(p1, p2);

            Console.WriteLine("(" + p1._x + ", " + p1._y + ")");
            Console.WriteLine("(" + p2._x + ", " + p2._y + ")");

            Console.ReadKey();
        }

        public static void Swapping(SwapPoints x, SwapPoints y)
        {
            int tempXX = x._x;
            int tempXY = x._y;
            x._x = y._x;
            x._y = y._y;
            y._x = tempXX;
            y._y = tempXY;
        }
    }
}