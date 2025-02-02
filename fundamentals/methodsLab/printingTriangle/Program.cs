using System.Text;

static void Triangle(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j} ");
        }
        Console.WriteLine();
    }
    for (int i = number - 1; i >= 1; i--)
    {
        for (int j = i; j >= 1; j--)
        {
            Console.Write($"{i - j + 1} ");
        }
        Console.WriteLine();
    }
}

int number = int.Parse(Console.ReadLine());


Triangle(number);

