using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine("_______List_______");

            List<string> CarsList = new List<string>();
            CarsList.Add("Audi");
            CarsList.Add("BMW");
            CarsList.Add("Honda");
            CarsList.Add("Mercedes");
            CarsList.Add("VolksWagen");
            CarsList.Add("Mercedes");
            CarsList.Add("Tesla");

            foreach(string car in CarsList)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("_______HashSet_______");

            HashSet<string> CarsHashSet = new HashSet<string>();
            CarsHashSet.Add("Audi");
            CarsHashSet.Add("BMW");
            CarsHashSet.Add("Honda");
            CarsHashSet.Add("Mercedes");
            CarsHashSet.Add("VolksWagen");
            CarsHashSet.Add("Mercedes");
            CarsHashSet.Add("Tesla");

            foreach (string car in CarsHashSet)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("_______Dictionary_______");

            Dictionary<string, string> CarsDictionary = new Dictionary<string, string>();
            CarsDictionary.Add("Audi", "Germany");
            CarsDictionary.Add("BMW", "Germany");
            CarsDictionary.Add("Honda", "Japan");
            CarsDictionary.Add("Mercedes", "Germany");
            CarsDictionary.Add("VolksWagen", "Germany");
            CarsDictionary.Add("Tesla", "USA");

            foreach (KeyValuePair<string, string> car in CarsDictionary)
            {
                Console.WriteLine($"{car.Key}, {car.Value}");
            }

            Console.ReadKey();
        }
    }
}