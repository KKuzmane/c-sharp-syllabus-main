
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2 a
            double initialVelocity = 0.0; // vi
            double fallingTime = 10.0; // t
            double initialPosition = 0.0; // xi
            double finalPosition = 0.0; // x(t)

            finalPosition = (0.5 * (gravity * Math.Pow(fallingTime, 2))) + (initialVelocity * fallingTime) + initialPosition;

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
