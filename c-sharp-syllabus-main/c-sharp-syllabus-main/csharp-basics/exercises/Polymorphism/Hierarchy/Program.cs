using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat("Lucijs", "Cat", 4.8, 1, "Latvia", "no breed"));
            animals.Add(new Tiger("Tobby", "Tiger", 121.21, 5, "Asia"));

            List<Food> foodList = new List<Food>();
            foodList.Add(new Vegetables(10));
            foodList.Add(new Meat(10));

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ShowAnimal());
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine($"{foodList[0]}");
                Console.WriteLine(animal.EatFood(foodList[0]));
            }

            Console.WriteLine("End");
            Console.WriteLine($"{animals[0]}, {animals[1]}");
            Console.ReadKey();
        }
    }
}