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
            // Get the user's menu choice.
            GetMenu();
        }

        public static int GetMenu()
        {

            int userChoice;
            

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            string keyboard = Console.ReadLine();
            // get input from user
            userChoice = Convert.ToInt32(keyboard);

            // validate input
            if(userChoice == 1)
            {
                CalculateCircleArea();
            }
            else if (userChoice == 2)
            {
                CalculateRectangleArea();
            }
            else if(userChoice == 3)
            {
                CalculateTriangleArea();
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

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            string inputRadius = Console.ReadLine();
            decimal radius = Convert.ToDecimal(inputRadius);


            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
            Console.ReadKey();
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user

            // Get length
            Console.WriteLine("Enter length? ");
            string inputLength = Console.ReadLine();
            length = Convert.ToDecimal(inputLength);

            // Get width
            Console.WriteLine("Enter width? ");
            string inputWidth = Console.ReadLine();
            width = Convert.ToDecimal(inputWidth);
            //todo

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
            Console.ReadKey();
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get input from user

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            string inputGround = Console.ReadLine();
            ground = Convert.ToDecimal(inputGround);
            Console.WriteLine("Your base is " + ground);
            //todo
            //read key value

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            string inputHeight = Console.ReadLine();
            height = Convert.ToDecimal(inputHeight);
            Console.WriteLine("Triangles height is " + height);
            //todo
            //read key value

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
            Console.ReadKey();
        }
    }
}

