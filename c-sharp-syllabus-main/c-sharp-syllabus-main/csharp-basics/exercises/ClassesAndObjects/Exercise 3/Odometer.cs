using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Odometer
    {
        public int _mileage;

        public Odometer(int currentMileage)
        {
            this._mileage = currentMileage;
        }

        public int StartMileage()
        {
            Console.WriteLine("Enter yout current mileage in km: ");
            int currentMileage = int.Parse(Console.ReadLine());
            this._mileage = currentMileage;
            return currentMileage;
        }

        public void Increment(int currentMileage)
        {
            if (currentMileage < 999999)
            {
                currentMileage++;
            }
            else
            {
                currentMileage = 0;
            }
            this._mileage = currentMileage;
        }

        public void FuelDecrement(FuelGauge carFuel)
        {
            if(this._mileage % 10 == 0)
            {
                carFuel.Decrement(carFuel._currentFuel);
            }
        }
        public int ReturnsCurrentMileage()
        {
            return this._mileage;
        }
    }
}