﻿using System;
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

        public static int GetMenu()
        {

            int userChoice;
            
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            string keyboard = Console.ReadLine();
            userChoice = Convert.ToInt32(keyboard);

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
            Console.WriteLine("What is the circle's radius? ");
            string inputRadius = Console.ReadLine();
            decimal radius = Convert.ToDecimal(inputRadius);

            if (Geometry.AreaOfCircle(radius) == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
            }
            Console.ReadKey();
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("Enter length? ");
            string inputLength = Console.ReadLine();
            length = Convert.ToDecimal(inputLength);

            Console.WriteLine("Enter width? ");
            string inputWidth = Console.ReadLine();
            width = Convert.ToDecimal(inputWidth);
            
            if (Geometry.AreaOfRectangle(length, width) == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
            }
            Console.ReadKey();
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");
            string inputGround = Console.ReadLine();
            ground = Convert.ToDecimal(inputGround);
            Console.WriteLine("Your base is " + ground);
            
            Console.WriteLine("Enter triangle's height? ");
            string inputHeight = Console.ReadLine();
            height = Convert.ToDecimal(inputHeight);
            Console.WriteLine("Triangles height is " + height);
            
            if (Geometry.AreaOfTriangle(ground, height) == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("The triangle's area is "
                        + Geometry.AreaOfTriangle(ground, height));
            }
            Console.ReadKey();
        }
    }
}

