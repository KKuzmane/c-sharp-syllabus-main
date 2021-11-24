// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input distance in meters: ");
string inputMeters = Console.ReadLine();
Console.WriteLine("Input time, that wwas taken:");
Console.WriteLine("hours - ");
string inputHours = Console.ReadLine();
Console.WriteLine("minutes - ");
string inputMinutes = Console.ReadLine();
Console.WriteLine("seconds - ");
string inputSeconds = Console.ReadLine();

double meters = Convert.ToInt32(inputMeters);
double hours = Convert.ToInt32(inputHours);
double minutes = Convert.ToInt32(inputMinutes);
double seconds = Convert.ToInt32(inputSeconds);

double secondsInHours = hours * 60 * 60;
double secondsInMinutes = minutes * 60;
double totalSeconds = seconds + secondsInHours + secondsInMinutes;

double secondsToHours = Math.Round((seconds / 3600), 8);
double minutesToHours = Math.Round((minutes / 60), 8);
double totalHours = hours + minutesToHours + secondsToHours;

double metersSeconds = Math.Round((meters / totalSeconds), 8);
double kmHour = Math.Round(((meters / 1000) / totalHours), 8);
double milesHour = Math.Round(((meters / 1609.344) / totalHours), 8);

Console.WriteLine("Your speed in meters/ second is " + metersSeconds);
Console.WriteLine("Your speed in km/h is " + kmHour);
Console.WriteLine("Your speed in miles/ h is " + milesHour);
