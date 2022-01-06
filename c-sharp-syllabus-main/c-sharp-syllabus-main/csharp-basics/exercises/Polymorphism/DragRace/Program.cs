using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<IDragRace> cars = new List<IDragRace>();

            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Ferrari());
            cars.Add(new Lexus());
            cars.Add(new Tesla());
            cars.Add(new VolksWagen());

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 0)
                    {
                        car.StartEngine();
                        continue;
                    }
                    else if (i == 3)
                    {
                        if (car is IBoostable boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                            continue;
                        }
                    }
                    car.SpeedUp();
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.GetType().Name + " : " + car.ShowCurrentSpeed() );
            }   
        }
    }
}