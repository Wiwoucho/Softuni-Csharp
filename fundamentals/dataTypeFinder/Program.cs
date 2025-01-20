﻿string input = Console.ReadLine();

while (input != "END")
{
    if (int.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (bool.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else if (float.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is floating point type");
    }
    else if (input.Length == 1)
    {
        Console.WriteLine($"{input} is character type");
    }
    else
    {
        Console.WriteLine($"{input} is string type");
    }

    input = Console.ReadLine();
}