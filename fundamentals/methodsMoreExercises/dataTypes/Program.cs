string input = Console.ReadLine();


static object GuessInput(string input)
{
    switch (input)
    {
        case "int":
            int value = int.Parse(Console.ReadLine());
            return $"{value * 2}";
        case "real":
            double number  = double.Parse(Console.ReadLine());
            return $"{number * 1.5:F2}";
        case "string":
            string str = Console.ReadLine();
            return $"${str}$";
        default:
            return null ;
    }
}

Console.WriteLine(GuessInput(input));