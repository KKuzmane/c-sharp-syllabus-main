using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private int NumberedSurveyed;
        private double PurchasedEnergyDrinks;
        private double PreferCitrusDrinks;

        private Program(int numberSurveyed, double purchasedEnergyDrinks, double preferCitrusDrinks)
        {
            NumberedSurveyed = numberSurveyed;
            PurchasedEnergyDrinks = purchasedEnergyDrinks;
            PreferCitrusDrinks = preferCitrusDrinks;
        }

        private static void Main(string[] args)
        {
            Program survey = new Program(12467, 0.14, 0.64);

            double count = survey.CalculateEnergyDrinkers();
            double newCount = survey.CalculatePreferCitrus(count);

            Console.WriteLine("Total number of people surveyed " + survey.ReturnSurveyedCount() + ".");
            Console.WriteLine("Approximately " + count + " bought at least one energy drink,");
            Console.WriteLine(newCount + " of those " + "prefer citrus flavored energy drinks.");

            Console.ReadKey();
        }

        double CalculateEnergyDrinkers()
        {
            double count = NumberedSurveyed * PurchasedEnergyDrinks;

            return count;
        }

        double CalculatePreferCitrus(double count)
        {
            double newCount = Math.Round((count * PreferCitrusDrinks), 2);

            return newCount;
        }
         int ReturnSurveyedCount()
         {
            return NumberedSurveyed;
         }
    }
}