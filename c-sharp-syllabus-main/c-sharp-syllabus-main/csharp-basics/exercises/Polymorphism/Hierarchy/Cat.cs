using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten,
            string livingRegion, string breed) : base(animalName,
            animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }

        public override string ShowAnimal()
        {
            return $"{_animalType} {_animalName}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}";
        }

        public override string EatFood(Food food)
        {
                _foodEaten += food._quantity;
                return $"{_animalType} {_animalName}, {_breed}, {_animalWeight}, {_livingRegion}, {_foodEaten}";
        }

        public override string MakeSound()
        {
            return "Miau...";
        }
    }
}
