static string PositiveNegativeNumber(int number)
{
    if (number > 0)
    {
        return $"The number {number} is positive.";
    }
    else if (number < 0)
    {
        return $"The number {number} is negative.";
    }
    else
    {
        return $"The number {number} is zero.";
    }
}

Console.WriteLine(PositiveNegativeNumber(int.Parse(Console.ReadLine())));