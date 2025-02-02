static string GetGrade(double number)
{
    if (number >= 2 && number <= 3)
    {
        return "Fail";
    }
    else if (number >= 3 && number <= 3.49)
    {
        return "Poor";
    }
    else if (number >= 3.5 && number <= 4.49)
    {
        return "Good";
    }
    else if (number >= 4.50 && number <= 5.49)
    {
        return "Very good";
    }
    else
    {
        return "Excellent";
    }
}

Console.WriteLine(GetGrade(double.Parse(Console.ReadLine())));