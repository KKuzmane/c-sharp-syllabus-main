// See https://aka.ms/new-console-template for more information

int result = 1;
const int lowerBound = 1;
const int upperBound = 10;

for (var number = lowerBound; number <= upperBound; ++number)
{
    result *= number;
}
Console.WriteLine("The result is " + result);
