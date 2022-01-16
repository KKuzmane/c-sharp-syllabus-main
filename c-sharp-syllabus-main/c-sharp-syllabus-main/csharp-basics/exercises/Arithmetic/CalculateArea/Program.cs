using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
        }

        public static void GetMenu()
        {
            
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            string keyboard = Console.ReadLine();
            int userChoice = Convert.ToInt32(keyboard);

            if(userChoice == 1)
            {
                Console.WriteLine("What is the circle's radius? ");
                string inputRadius = Console.ReadLine();
                decimal radius = Convert.ToDecimal(inputRadius);
                CalculateArea.CalculateCircleArea(radius);
            }
            else if (userChoice == 2)
            {
                Console.WriteLine("Enter length? ");
                string inputLength = Console.ReadLine();
                decimal length = Convert.ToDecimal(inputLength);

                Console.WriteLine("Enter width? ");
                string inputWidth = Console.ReadLine();
                decimal width = Convert.ToDecimal(inputWidth);

                CalculateArea.CalculateRectangleArea(length, width);
            }
            else if(userChoice == 3)
            {
                Console.WriteLine("Enter length of the triangle's base? ");
                string inputGround = Console.ReadLine();
                decimal ground = Convert.ToDecimal(inputGround);
                Console.WriteLine("Your base is " + ground);

                Console.WriteLine("Enter triangle's height? ");
                string inputHeight = Console.ReadLine();
                decimal height = Convert.ToDecimal(inputHeight);
                Console.WriteLine("Triangles height is " + height);

                CalculateArea.CalculateTriangleArea(ground, height);
            }
            else if(userChoice == 4)
            {
                Console.WriteLine("Bye!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error! Please choose a number from menu!");
            }

            Console.ReadKey();
        }
    }
}

