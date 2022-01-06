using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> sounds = new List<ISound>();

            Parrot parrot1 = new Parrot();
            sounds.Add(parrot1);
            Parrot parrot2 = new Parrot();
            sounds.Add(parrot2);
            Radio radio1 = new Radio();
            sounds.Add(radio1);
            Radio radio2 = new Radio();
            sounds.Add(radio2);
            Firework firework1 = new Firework();
            sounds.Add(firework1);
            Firework firework2 = new Firework();
            sounds.Add(firework2);

            foreach (var sound in sounds)
            {
                sound.PlaySound();
            }

            Console.ReadKey();
        }
    }
}