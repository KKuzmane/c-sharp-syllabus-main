using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BMI = weight * 703 / height ^ 2 (weight - pounds, height - inches)
            double optimalBMIMin = 18.5;
            double optimalBMIMax = 25;
            double pundMultiplyer = 0.45359237;
            double inchMultiplyer = 2.54;
            Console.WriteLine("Insert your weight (kg): ");
            string inputWeightKg = Console.ReadLine();
            double weight = (Convert.ToDouble(inputWeightKg) / pundMultiplyer);
            Console.WriteLine("Insert your height (cm): ");
            string inputHeightM = Console.ReadLine();
            double height = (Convert.ToDouble(inputHeightM) * (1/ inchMultiplyer));
            double BMI = Math.Round(((weight * 703) / (Math.Pow(height, 2))), 2);
            //Console.WriteLine(height);
           // Console.WriteLine(weight);
          
            if(BMI < optimalBMIMin)
            {
                Console.WriteLine("Your BMI is " + BMI + ". Optimal BMI is 18.5 - 25, so you are underweight.");
            }
            else if (BMI > optimalBMIMax)
            {
                Console.WriteLine("Your BMI is " + BMI + ". Optimal BMI is 18.5 - 25, so you are overweight.");
            }
            else
            {
                Console.WriteLine("Your BMI is " + BMI + ". You are optimal weight");
            }

            Console.ReadKey();
        }
    }
}
