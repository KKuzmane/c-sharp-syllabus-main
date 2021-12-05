﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);
            Car car2 = new Car(100);
            for (int i = 0; i < 1; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);

                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car2.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Car kilometers per liter are " + car.CalculateConsumption() + " economyCar:" + car.EconomyCar() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption()+ " economyCar:" + car1.EconomyCar() + " gasHog:" + car1.GasHog());
            Console.WriteLine("Car2 Kilometers per liter are " + car2.CalculateConsumption() + " economyCar:" + car2.EconomyCar() + " gasHog:" + car2.GasHog());
            Console.ReadKey();
        }
    }
}
