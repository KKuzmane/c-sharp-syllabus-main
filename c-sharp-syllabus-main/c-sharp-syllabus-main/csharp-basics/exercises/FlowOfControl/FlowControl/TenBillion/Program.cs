using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();
            string length = Convert.ToString(input);
            long number = Convert.ToInt64(input);

            if (length.Length <= 11) 
            {
                if (number < 0) 
                {
                    number *= -1;
                }

                string newNumber = number.ToString();

                if (newNumber.Length > 10) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (newNumber.Length == 2) 
                    {
                        digits = 2;
                    } 
                    else if (newNumber.Length == 3) 
                    {
                        digits = 3;
                    } 
                    else if (newNumber.Length == 4) 
                    {
                        digits = 4;
                    } 
                    else if (newNumber.Length == 5) 
                    {
                        digits = 5;
                    } 
                    else if (newNumber.Length == 6) 
                    {
                        digits = 6;
                    } 
                    else if (newNumber.Length == 7) 
                    {
                        digits = 7;
                    } 
                    else if (newNumber.Length == 8) 
                    {
                        digits = 8;
                    } 
                    else if (newNumber.Length == 9) 
                    {
                        digits = 9;
                    } 
                    else if (newNumber.Length == 10) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadKey();
        }
    }
}
