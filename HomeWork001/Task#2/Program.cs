Console.WriteLine("Input the fisrt number: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("max = ");
    Console.WriteLine(numberA);
}
else
{
    Console.WriteLine("max = ");
    Console.WriteLine(numberB);
}