using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        public const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            string[] readText = File.ReadAllLines(Path);

            var createCities = Planner.InsertText(readText);

            Planner.DisplayStartCities(createCities);

            string input = Planner.InputCity();

            var roundtrip = Planner.DisplayNewPossibleDestinations(createCities, input);

            Console.WriteLine();
            Console.WriteLine("Your round trip is booked! See it below:");
            foreach (var city in roundtrip)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("Thanks for shopping with us. Bye!");
            Console.ReadKey();
        }
    }
}