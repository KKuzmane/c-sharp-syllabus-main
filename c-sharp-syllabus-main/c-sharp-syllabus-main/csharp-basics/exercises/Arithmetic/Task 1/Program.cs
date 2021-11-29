// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your first integer: ");
string xInput = Console.ReadLine();
Console.WriteLine("Enter your second integer: ");
string yInput = Console.ReadLine();

int x = Convert.ToInt32(xInput);
int y = Convert.ToInt32(yInput);

if((x == 15) || (y == 15) || ((x + y) == 15) || ((x - y) == 15) || ((y - x) == 15))
{
    Console.WriteLine(true);
}