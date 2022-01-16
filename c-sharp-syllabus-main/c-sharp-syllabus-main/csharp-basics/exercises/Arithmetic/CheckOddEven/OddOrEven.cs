using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddEven
{
    public class OddOrEven
    {
        public string InsertNumber()
        {
            Console.WriteLine("Enter your number here: ");
            string xInput = Console.ReadLine();

            return xInput;
        }

        public int ConvertInputToInt(string Input)
        {
            int x = Convert.ToInt32(Input);
            return x;
        }

        public string CheckIfOddOrEven(int x)
        {
            if ((x % 2) == 0)
            {
                return "Even Number";
            }
            else
            {
                return "Odd Number";
            }
        }
    }
}
