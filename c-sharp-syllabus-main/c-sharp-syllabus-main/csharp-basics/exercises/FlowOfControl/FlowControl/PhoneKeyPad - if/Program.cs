using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneKeyPad___if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your text: ");
            string text = Console.ReadLine().ToLower();
            int textLenght = text.Length;

            for (int i = 0; i < textLenght; i++)
            {
                char charsInString = text.ToCharArray()[i];

                if (charsInString == 'a' || charsInString == 'b' || charsInString == 'c')
                {
                    Console.Write(2);
                }
                else if (charsInString == 'd' || charsInString == 'e' || charsInString == 'f')
                {
                    Console.Write(3);
                }
                else if (charsInString == 'g' || charsInString == 'h' || charsInString == 'i')
                {
                    Console.Write(4);
                }
                else if (charsInString == 'j' || charsInString == 'k' || charsInString == 'l')
                {
                    Console.Write(5);
                }
                else if (charsInString == 'm' || charsInString == 'n' || charsInString == 'o')
                {
                    Console.Write(6);
                }
                else if (charsInString == 'p' || charsInString == 'q' || charsInString == 'r' || charsInString == 's')
                {
                    Console.Write(7);
                }
                else if (charsInString == 't' || charsInString == 'u' || charsInString == 'v')
                {
                    Console.Write(8);
                }
                else if (charsInString == 'w' || charsInString == 'x' || charsInString == 'y' || charsInString == 'z')
                {
                    Console.Write(9);
                }
                else
                {
                    Console.Write(charsInString);
                }
            }
            Console.ReadKey();
        }
    }
}
