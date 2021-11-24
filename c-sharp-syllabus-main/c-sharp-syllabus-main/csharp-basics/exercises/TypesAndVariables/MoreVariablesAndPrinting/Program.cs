using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string eyes;
            string teeth;
            string hair;
            int age;
            int heightInches;
            int weightLbs;
            double heightCm;
            double weightKg;

            name = "Zed A. Shaw";
            age = 35;
            heightInches= 74;  
            heightCm = Math.Round((heightInches * 0.39370079), 2);
            weightLbs = 180;
            weightKg = Math.Round((weightLbs / 2.2046), 2);
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightCm + " centimeters tall.");
            Console.WriteLine("He's " + weightKg + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightCm + ", and " + weightKg
                               + " I get " + (age + heightCm + weightKg) + ".");

            Console.ReadKey();
        }
    }
}