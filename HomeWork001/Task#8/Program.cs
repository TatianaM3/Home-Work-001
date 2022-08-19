Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int x = 1;

while (x<=N)
{
    if (x % 2 == 0)
    {
        Console.WriteLine (x);
    }
    x = x + 1;
}
