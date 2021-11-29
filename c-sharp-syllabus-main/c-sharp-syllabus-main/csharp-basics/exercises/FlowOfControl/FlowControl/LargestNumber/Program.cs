using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var insertedInput1 = Console.ReadLine();
            int input1 = Convert.ToInt32(insertedInput1);

            Console.WriteLine("Input the 2nd number: ");
            var insertedInput2 = Console.ReadLine();
            int input2 = Convert.ToInt32(insertedInput2);

            Console.WriteLine("Input the 3rd number: ");
            var insertedInput3 = Console.ReadLine();
            int input3 = Convert.ToInt32(insertedInput3);

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine("Biggest number is " + input1);
            }
            else if( input2 > input1 && input2 > input3)
            {
                Console.WriteLine("Biggest number is " + input2);
            }
            else if (input3> input1 && input3 > input2)
            {
                Console.WriteLine("Biggest number is " + input3);
            }
            else if (input1 == input2 && input1 > input3)
            {
                Console.WriteLine("Biggest number is " + input1);
            }
            else if (input1 == input3 && input1 > input2)
            {
                Console.WriteLine("Biggest number is " + input1);
            }
            else if (input2 == input3 && input2 > input1)
            {
                Console.WriteLine("Biggest number is " + input3);
            }
            else
            {
                Console.WriteLine("Biggest number is " + input1); //Returns a value if all three numbers are equal
            }
            Console.ReadKey();
        }
    }
}
