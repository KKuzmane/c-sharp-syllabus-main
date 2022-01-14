using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class IsItFifteen
    {
        public string InputFirstNumber()
        {
            Console.WriteLine("Enter your first integer: ");
            string xInput = Console.ReadLine();

            return xInput;
        }

        public string InputSecondNumber()
        {
            Console.WriteLine("Enter your first integer: ");
            string yInput = Console.ReadLine();

            return yInput;
        }

        public int FirstNumber(string xInput)
        {
            int x = Convert.ToInt32(xInput);

            return x;
        }

        public int SecondNumber(string yInput)
        {
            int y = Convert.ToInt32(yInput);

            return y;
        }

        public bool IsFifteen(int x, int y)
        {
            return (x == 15) || (y == 15) || ((x + y) == 15) || ((x - y) == 15) || ((y - x) == 15);
        }
    }
}
