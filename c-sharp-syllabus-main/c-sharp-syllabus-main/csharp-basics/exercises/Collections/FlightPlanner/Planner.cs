using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class Planner
    {
        public static Dictionary<string, List<string>> InsertText(string[] path)
        {
            Dictionary<string, List<string>> flights = new Dictionary<string, List<string>>();
            List<string> destinations;

            foreach (string s in path)
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

            return flights;
        }

        public static void DisplayStartCities(Dictionary<string, List<string>> flights)
        {
            foreach (var flight in flights)
            {
                Console.WriteLine($"{flight.Key}");
            }
        }

        public static string InputCity()
        {
            Console.WriteLine("Insert name of the city");
            string input = Console.ReadLine();
            Console.WriteLine($"You chose {input}");

            return input;
        }

        public static List<string> DisplayNewPossibleDestinations(Dictionary<string, List<string>> flights, string firstInput)
        {
            List<string> chosenCities = new List<string>();
            chosenCities.Add(firstInput);
            string input = " ";

            while (chosenCities[0] != input)
            {
                foreach (var flight in flights)
                {
                    input = firstInput;
                    while (!flights.ContainsKey(input))
                    {
                        Console.WriteLine("This city is not in our list. Try again.");
                        Console.WriteLine("Enter city name from where You want to fly: ");

                        chosenCities.RemoveAt(chosenCities.Count - 1);
                        input = InputCity();
                        chosenCities.Add(input);
                        firstInput = input;
                    }

                    if (input == flight.Key)
                    {
                        Console.WriteLine($"From {flight.Key} you can fly to: ");
                        foreach (string endDestinations in flight.Value.Distinct())
                        {
                            Console.WriteLine(endDestinations);
                        }
                    }
                }
                input = InputCity();
                chosenCities.Add(input);
                firstInput = input;
            }
            return chosenCities;
        }
    }
}