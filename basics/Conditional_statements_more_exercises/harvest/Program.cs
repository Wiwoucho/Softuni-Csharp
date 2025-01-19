int x = int.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int workers_count = int.Parse(Console.ReadLine());

double total_grapes_from_harvest = x * y;
double wine_produced = (total_grapes_from_harvest * 0.4) / 2.5;  //2.5 is grapes needed for 1 liter of wine

if (wine_produced >= z)

    {
    double liters_left = Math.Ceiling(wine_produced - z);
    double workers_wine_liters_per_person = Math.Ceiling(liters_left / workers_count);
    
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine_produced)} liters.");
    Console.WriteLine($"{Math.Ceiling(liters_left)} liters left -> {workers_wine_liters_per_person} liters per person.");
    }
else
    {
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine_produced)} liters wine needed.");
    }
