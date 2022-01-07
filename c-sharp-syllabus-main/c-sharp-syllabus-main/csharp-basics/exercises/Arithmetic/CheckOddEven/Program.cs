using CheckOddEven;

string InputX = new OddOrEven().InsertNumber();
int x = new OddOrEven().ConvertInputToInt(InputX);
Console.WriteLine(new OddOrEven().CheckIfOddOrEven(x));

Console.WriteLine("Bye!");