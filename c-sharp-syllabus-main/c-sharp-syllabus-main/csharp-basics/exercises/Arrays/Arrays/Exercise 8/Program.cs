using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "kumode", "laukakmens", "latvietis" };
            var rnd = new Random();
            var word = words[rnd.Next(0, words.Length)];
            var guessable = new string('_', word.Length);
            var misses = string.Empty;
            int counter = 0;
            int turnLimit = 15;
            int leftTurns = turnLimit;

            while (guessable.IndexOf('_') != -1)
            {
                counter++;
                if (counter == 16)
                {
                    Console.WriteLine("Word: " + guessable);
                    Console.WriteLine("You lose! :(");
                    break;
                }
                Console.WriteLine("Word: " + guessable);
                Console.WriteLine("Misses: " + misses);
                Console.WriteLine("Turns left: " + leftTurns);

                var input = Console.ReadKey();
                Console.WriteLine();
                var guess = input.KeyChar;
                Console.WriteLine("Guess: " + guess);

                if (word.ToLower().IndexOf(guess) > -1)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }

                leftTurns = turnLimit - counter;
                if(guessable == word)
                {
                    Console.WriteLine("Word: " + guessable);
                    Console.WriteLine("You won!");
                }
            }
            Console.ReadKey();
        }
    }
}
