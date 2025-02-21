using System.Numerics;

static BigInteger Factorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    return number * Factorial(number - 1);
}


BigInteger factorial = Factorial(int.Parse(Console.ReadLine()));

Console.WriteLine(factorial);