﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string _animalName;
        protected string _animalType;
        protected double _animalWeight;
        protected int _foodEaten;

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public virtual string ShowAnimal()
        {
            return $"{_animalType} {_animalName} {_animalWeight}";
        }

        public override string ToString()
        {
            return _animalType;
        }

        public abstract string EatFood(Food food);

        public abstract string MakeSound();
    }
}
