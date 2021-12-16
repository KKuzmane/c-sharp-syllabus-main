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
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            Dictionary<string, List<string>> flights = new Dictionary<string, List<string>>();
            List<string> destinations;
            List<string> chosenCities = new List<string>();

            foreach (var s in readText)
            {
                string[] fromTo = Regex.Split(s, " -> ");

                if (!flights.TryGetValue(fromTo[0], out destinations))
                {
                    destinations = new List<string>();
                    flights.Add(fromTo[0], destinations);
                }
                else
                {
                    flights[fromTo[0]].Add(fromTo[1]);
                }

                if (!flights.TryGetValue(fromTo[1], out destinations))
                {
                    destinations = new List<string>();
                    flights.Add(fromTo[1], destinations);
                }
                else
                {
                    flights[fromTo[1]].Add(fromTo[0]);
                }
            }

            Console.WriteLine("Enter city name where you want to go first");
            foreach (var flight in flights)
            {
                Console.WriteLine($"{flight.Key}");
            }

            string firstInput = Console.ReadLine();
            chosenCities.Add(firstInput);
            string input = "";

            while (chosenCities[0] != input)
            {
                input = firstInput;
                while (!flights.ContainsKey(input))
                {
                    Console.WriteLine("This city is not in our list. Try again.");
                    Console.WriteLine("Enter city name from where You want to fly: ");
                    
                    chosenCities.RemoveAt(chosenCities.Count - 1);
                    input = Console.ReadLine();
                    chosenCities.Add(input);
                }

                foreach (var flight in flights)
                {
                    if (input == flight.Key)
                    {
                        Console.WriteLine($"From {flight.Key} you can fly to: ");
                        foreach (string endDestinations in flight.Value.Distinct())
                        {
                            Console.WriteLine(endDestinations);
                        }
                    }
                }
                input = Console.ReadLine();
                chosenCities.Add(input);
                firstInput = input;
            }
            Console.WriteLine("Your round trip is booked! Thanks for choosing us.");
            Console.ReadKey();
        }
    }
}