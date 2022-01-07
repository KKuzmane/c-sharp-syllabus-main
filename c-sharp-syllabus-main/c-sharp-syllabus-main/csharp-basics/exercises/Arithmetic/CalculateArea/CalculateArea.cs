using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class CalculateArea
    {
        public static double CalculateCircleArea(decimal radius)
        {
            double area = 0;

            if (Geometry.AreaOfCircle(radius) == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                area = Geometry.AreaOfCircle(radius);
                Console.WriteLine("The circle's area is " + area);
            }
            return area;
        }

        public static double CalculateRectangleArea(decimal length, decimal width)
        {
            double area = 0;

            if (Geometry.AreaOfRectangle(length, width) == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                area = Geometry.AreaOfRectangle(length, width);
                Console.WriteLine("The rectangle's area is " + area);
            }

            return area;
        }

        public static double CalculateTriangleArea(decimal ground, decimal height)
        {
            double area = 0;

            if (Geometry.AreaOfTriangle(ground, height) == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                area = Geometry.AreaOfTriangle(ground, height);
                Console.WriteLine("The triangle's area is " + area);
            }
            return area;
        }
    }
}
