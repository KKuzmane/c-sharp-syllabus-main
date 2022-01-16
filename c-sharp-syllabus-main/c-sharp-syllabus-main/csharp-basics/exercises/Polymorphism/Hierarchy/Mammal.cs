using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mammal : Animal
    {
        protected string _livingRegion;

        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public override string ShowAnimal()
        {
            return $"{_animalType} {_animalName} {_animalWeight} {_livingRegion}";
        }

        public override string ToString()
        {
            return $"{_animalType} [{_animalName}, {_animalWeight}, {_livingRegion}, {_foodEaten}]";
        }

        public override string EatFood(Food food)
        {
            return "";
        }

        public override string MakeSound()
        {
            return "";
        }
    }
}
