using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n;
            int answer = 1;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number you want to multiply : ");
            i = Convert.ToInt32(Console.ReadLine());
            
            for (int j = 1; j <= n; j++)
            {
                answer *= i;
            }
            Console.WriteLine($"{i} has been multiplyed {n} times. Resoult is: {answer}");
            Console.ReadKey();
        }
    }
}
