string fuelName = Console.ReadLine();
double fuelLiters = double.Parse(Console.ReadLine());

if (fuelName == "Gasoline" || fuelName == "Gas" || fuelName == "Diesel")
{
    if (fuelLiters > 24)
    {
        Console.WriteLine($"You have enough {fuelName.ToLower()}.");
    }
    else
    {
        Console.WriteLine($"Fill your tank with {fuelName.ToLower()}!");
    }
}
else
{
    Console.WriteLine("Invalid fuel!");
}
