// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter minutes: ");
string minutes = Console.ReadLine();
double writtenMinutes = Convert.ToDouble(minutes);

if(writtenMinutes < 0)
{
    Console.WriteLine("Please enter positive number!");
}

double minutesInYear = 60 * 24 * 365;
double minutesInLongYear = 60 * 24 * 366;
double minutesInDay = 60 * 24;

double minutesToYears = Math.Round((writtenMinutes / minutesInYear), 5);
double minutesToDays = Math.Round((writtenMinutes / minutesInDay), 2);
double minutesToLongYears = Math.Round((writtenMinutes / minutesInLongYear), 5);

Console.WriteLine(writtenMinutes + " minutes is approximately " + minutesToDays + " days or " + minutesToYears + " years. If it is a long year, then it will be " +
    minutesToLongYears + " yeasrs.");