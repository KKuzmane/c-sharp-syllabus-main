using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten,
            string livingRegion, string breed) : base(animalName,
            animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public override void ShowAnimal()
        {
            Console.WriteLine($"{_animalType} {_animalName}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}");
        }

        public override void EatFood(Food food)
        {
                _foodEaten += food._quantity;
                Console.WriteLine($"{_animalType} {_animalName}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miau...");
        }
    }
}
