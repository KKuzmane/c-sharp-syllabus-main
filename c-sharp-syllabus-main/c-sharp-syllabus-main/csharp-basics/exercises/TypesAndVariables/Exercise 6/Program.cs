// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your first integer number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your second integer number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your third integer number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int sum = firstNumber + secondNumber + thirdNumber;

Console.WriteLine("Sum of your numbers is: " + sum + ".");