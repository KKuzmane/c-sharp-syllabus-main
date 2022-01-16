using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public class Calculations
    {
        public double GravityCalculator(double fallingTimeSeconds)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2 a
            double initialVelocity = 0.0; // vi
            double initialPosition = 0.0; // xi

            double finalPosition = (0.5 * (gravity * Math.Pow(fallingTimeSeconds, 2))) + (initialVelocity * fallingTimeSeconds) + initialPosition;

            return finalPosition;
        }
    }
}
