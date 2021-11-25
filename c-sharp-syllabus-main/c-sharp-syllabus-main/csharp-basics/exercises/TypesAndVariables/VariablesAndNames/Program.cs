using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars;
            int drivers; 
            int passengers;
            double seatsInCar;
            double carpoolCapacity;
            double averagePassengersPerCar;
            double carsNotDriven;
            double carsDriven;

            cars = 100;
            seatsInCar = 4.0;
            drivers = 28;
            passengers = 90;
            carsDriven = drivers;
            carsNotDriven = cars - carsDriven;
            carpoolCapacity = carsDriven * seatsInCar;
            averagePassengersPerCar = Math.Round((passengers / carsDriven), 2);

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}