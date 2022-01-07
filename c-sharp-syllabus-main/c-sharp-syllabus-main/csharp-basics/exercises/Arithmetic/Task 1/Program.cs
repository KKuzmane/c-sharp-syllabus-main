using Task_1;

string xInput = new IsItFifteen().InputFirstNumber();
string yInput = new IsItFifteen().InputSecondNumber();
int isItFifteenX = new IsItFifteen().FirstNumber(xInput);
int isItFifteenY = new IsItFifteen().SecondNumber(yInput);
var isFifteen = new IsItFifteen().IsFifteen(isItFifteenX, isItFifteenY);
Console.WriteLine(isFifteen);

Console.ReadKey();
