int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishermanCount = int.Parse(Console.ReadLine());

double boatPrice = 0;


switch (season)
{
    case "Spring":
        boatPrice = 3000;
        break;

    case "Autumn":
    case "Summer":
        boatPrice = 4200;
        break;

    case "Winter":
        boatPrice = 2600;
        break;
}



if (fishermanCount <= 6)
{
    boatPrice *= 0.9; // 10% discount if the group is less than or equal to 6
}
else if (fishermanCount >= 7 && fishermanCount <= 11)
{
    boatPrice *= 0.85; // 15% discount if the group is between 7 and 11
}
else
{
    boatPrice *= 0.75; // 25% discount if the group is more than 12 
}

if (fishermanCount % 2 == 0 && season != "Autumn")
{
    boatPrice *= 0.95; // 5% discount if the group is even number
}

if (budget >= boatPrice)
{
    Console.WriteLine($"Yes! You have {budget - boatPrice:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {boatPrice - budget:f2} leva.");
}