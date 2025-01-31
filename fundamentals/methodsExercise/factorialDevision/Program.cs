double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

static double Factorial(double num)
{
    if (num == 0 || num == 1)
    {
        return 1;
    }

    return num * Factorial(num - 1);
}

Console.WriteLine($"{Factorial(num1) / Factorial(num2):F2}");