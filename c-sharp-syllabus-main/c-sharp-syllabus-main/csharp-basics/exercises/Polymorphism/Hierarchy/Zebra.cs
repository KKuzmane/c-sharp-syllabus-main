using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten,
            string livingRegion) : base(animalName,
            animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override void ShowAnimal()
        {
            Console.WriteLine($"{_animalType} {_animalName}, {_animalWeight}, {_livingRegion}, {_foodEaten}");
        }

        public override void EatFood(Food food)
        {
            if (food is Vegetables)
            {
                _foodEaten += food._quantity;
                Console.WriteLine($"{_animalType} {_animalName} {_animalWeight}, {_livingRegion}, {_foodEaten}");
            }
            else
            {
                Console.WriteLine($"{_animalType} is not eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Khe khe khe");
        }
    }
}
