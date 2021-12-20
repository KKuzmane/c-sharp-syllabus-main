using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class FuelGauge
    {
        public double CurrentFuel;

        public FuelGauge(double currentFuel)
        {
            this.CurrentFuel = currentFuel;
        }

        public double StartFuel()
        {
            Console.WriteLine("Enter yout current fuel amount in liters");
            double currentFuel = double.Parse(Console.ReadLine());
            this.CurrentFuel = currentFuel;
            return currentFuel;
        }

        public void Increment(double currentFuel)
        {
            if (currentFuel < 70)
            {
                this.CurrentFuel = 70;
            }
            else
            {
                Console.WriteLine("Gas tank is full. You must drive!");
                this.CurrentFuel = 70;
            }
        }

        public void Decrement(double currentFuel)
        {
            if (currentFuel > 0)
            {
                currentFuel--;
            }
            else
            {
                currentFuel = 0;
            }
            this.CurrentFuel = currentFuel;
        }

        public double ReturnsCurrentFuel()
        {
            return this.CurrentFuel;
        }

        static void Main(string[] args)
        {
            FuelGauge fuelCar1 = new FuelGauge(0);
            double currentFuelCar1 = fuelCar1.StartFuel();
            Odometer mileageCar1 = new Odometer(0);
            int currentMileageCar1 = mileageCar1.StartMileage();

            fuelCar1.Increment(currentFuelCar1);

            while(fuelCar1.CurrentFuel > 0)
            {
                mileageCar1.Increment(mileageCar1._mileage);
                mileageCar1.FuelDecrement(fuelCar1);

                Console.WriteLine($"Mileage: {mileageCar1._mileage}");
                Console.WriteLine($"Fuel level: {fuelCar1.ReturnsCurrentFuel()}");
                Console.WriteLine("_________________________");
            }
            Console.ReadKey();
        }
    }
}
