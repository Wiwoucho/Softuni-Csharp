int n = int.Parse(Console.ReadLine());
string day_or_night = Console.ReadLine();

double bus_price_per_km = 0.09;
double train_price_per_km = 0.06;
double taxi_starting_price = 0.70;

if (day_or_night == "day")
{
    double taxi_price_per_km = 0.79;
 

    if (n >= 100)
    {
        Console.WriteLine($"{train_price_per_km * n:f2}");
    }
    else if (n >= 20)
    {
        Console.WriteLine($"{bus_price_per_km * n:f2}");
    }
    else
    {
        Console.WriteLine($"{taxi_starting_price + (taxi_price_per_km * n):f2}");
    }
}

if (day_or_night == "night")
{
    double taxi_price_per_km = 0.90;

    if (n >= 100)
    {
        Console.WriteLine($"{train_price_per_km * n:f2}");
    }
    else if (n >= 20)
    {
        Console.WriteLine($"{bus_price_per_km * n:f2}");
    }
    else
    {
        Console.WriteLine($"{taxi_starting_price + (taxi_price_per_km * n):f2}");
    }
}
