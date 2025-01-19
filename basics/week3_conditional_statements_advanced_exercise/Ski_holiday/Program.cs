int daysForStaying = int.Parse(Console.ReadLine()) - 1;
string roomType = Console.ReadLine();
bool isPoisitive = Console.ReadLine() == "positive";

double roomPrice = 18;
double apartmentPrice = 25;
double presidentApartmentPrice = 35;

double totalPrice = 0;

switch (roomType)
{
    case "room for one person":
        totalPrice = roomPrice * daysForStaying;
        break;
    case "apartment":
        totalPrice = daysForStaying * apartmentPrice;

        if (daysForStaying < 10)
        {
            totalPrice *= 0.7; // 30% discount for less than 10 days
        }
        else if (daysForStaying >= 10 && daysForStaying <= 15)
            totalPrice *= 0.65; // 35% discount between 10 and 15 days
        else
        {
            totalPrice *= 0.5; // 50% discount for more than 15 days
        }
        break;

    case "president apartment":

        totalPrice = daysForStaying * presidentApartmentPrice;

        if (daysForStaying < 10)
        {
            totalPrice *= 0.9; // 10% discount for less than 10 days
        }
        else if(daysForStaying >= 10 && daysForStaying<= 15)
        {
            totalPrice *= 0.85; // 15% discount between 10 and 15 days
        }
        else
        {
            totalPrice *= 0.8; // 20% discount for more than 15 days
        }
        break;
}

if (isPoisitive)
{
    totalPrice *= 1.25; // if he is happy with the stay he add additional 25% to the total price
}
else
{
    totalPrice *= 0.9; // if he is not happy reduce the total price with 10%
}


Console.WriteLine($"{totalPrice:f2}");