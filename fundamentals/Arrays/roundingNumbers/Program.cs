string[] numbers = Console.ReadLine().Split(" ");


foreach (string number in numbers)
{
    double value = double.Parse(number);
    double precision = (int)Math.Round(value, MidpointRounding.AwayFromZero);

    Console.WriteLine($"{number} => {precision}");

}