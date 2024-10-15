using System.ComponentModel.Design;

static bool IsPrime(int number)
{
    if (number <= 1)
        return false; 

    for (int i = 2; i <= Math.Sqrt(number); i++) 
    {
        if (number % i == 0)
            return false; 
    }
    return true; 
}

string text = Console.ReadLine();

int primeSum = 0;
int nonPrimeSum = 0;

while (text != "stop")
{
    int number = int.Parse(text);

    if (IsPrime(number))
    {
        primeSum += number;
    }
    else if (!IsPrime(number) && number >= 0)
    {
        nonPrimeSum += number;
    }
    else
    {
        Console.WriteLine("Number is negative.");
    }

    text = Console.ReadLine();
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");