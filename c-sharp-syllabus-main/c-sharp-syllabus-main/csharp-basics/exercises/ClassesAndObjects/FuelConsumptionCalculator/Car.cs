using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        public double startOdo, endOdo, liters;
        double startKilometers;

        public Car(double startOdo)
        {     
            this.startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return this.ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            double fuelConsumption = Math.Round(this.liters / ((this.endOdo - this.startOdo) / 100), 2);

            return fuelConsumption;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            this.liters = liters;
            this.endOdo = mileage;
        }
    }
}