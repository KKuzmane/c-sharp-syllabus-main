// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Enter your number here: ");
    string xInput = Console.ReadLine();
    int x = Convert.ToInt32(xInput);

    if ((x % 2) == 0)
    {
        Console.WriteLine("Even Number");
    }
    else
    {
        Console.WriteLine("Odd Number");
    }

    Console.WriteLine("Bye!");
