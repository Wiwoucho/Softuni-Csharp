int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());


static int SumTwo(int a, int b)
{
    return a + b;
}

static int SubtractTwo(int a, int b)
{
    return a - b;
}

int sum = SumTwo(a, b);
Console.WriteLine(SubtractTwo(sum, c));