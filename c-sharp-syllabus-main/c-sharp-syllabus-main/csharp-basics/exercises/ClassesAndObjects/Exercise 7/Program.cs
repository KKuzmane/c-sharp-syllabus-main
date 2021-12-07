using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male", "Lady", "Rocky");
            Dog rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male", "Lady", "Sparky");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine($"{coco.ReturnName()} father is {coco.ReturnFather()}, but mother is {coco.ReturnMother()}.");
            Console.WriteLine($"{sparky.ReturnName()} father is {sparky.ReturnFather()}, but mother is {sparky.ReturnMother()}.");
            Console.WriteLine(coco.HasSameMotherAs(rocky));

            Console.ReadKey();
        }
    }
}
