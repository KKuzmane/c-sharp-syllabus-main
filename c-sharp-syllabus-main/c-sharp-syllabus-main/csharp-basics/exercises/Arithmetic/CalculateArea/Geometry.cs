using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {            double newRadius = Convert.ToDouble(radius);
            if (newRadius < 0)
            {
                return 0;
            }
            else
            {
                double pi = 3.14159265359;
                double area = Math.Round((newRadius * pi * 2), 2);
                return area;
            }
            throw new NotImplementedException();
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            double newLenght = Convert.ToDouble(length);
            double newWidth = Convert.ToDouble(width);
            if (newLenght < 0 || newWidth < 0)
            {
                return 0;
            }
            else
            {
                double area = Math.Round((newLenght * newWidth), 2);
                return area;
            }
            throw new NotImplementedException();
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            double newGround = Convert.ToDouble(ground);
            double newH = Convert.ToDouble(h);
            /*if (newGround < 0 || newH < 0)
            {
                return 0;
            }*/
            //else
            //{
                double area = Math.Round((newGround * newH * 0.5), 2);
                return area;
           // }
            throw new NotImplementedException();
        }
    }
}
