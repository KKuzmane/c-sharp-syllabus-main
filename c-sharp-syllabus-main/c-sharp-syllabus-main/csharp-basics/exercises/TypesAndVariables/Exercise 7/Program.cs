// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your favorite quote: ");
string quote = Console.ReadLine();

string[] letters = quote.Split();

int NumberOfUpperLetters = 0;

for(int i = 0; i<quote.Length; i++)
{
    char letter = quote[i]; 
    if(letter >= 'A' && letter <= 'Z')
    {
        NumberOfUpperLetters++;
    }
}
    

Console.WriteLine("Number of upper letters in Your quote: " + NumberOfUpperLetters);
