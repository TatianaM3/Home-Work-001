Console.WriteLine("Input the fisrt number: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Input the third number: ");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine("max = ");
Console.WriteLine(max);