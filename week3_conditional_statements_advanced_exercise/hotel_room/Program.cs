string month = Console.ReadLine();
int daysForVacation = int.Parse(Console.ReadLine());

double priceForApartment = 0;
double priceForStudio = 0;
double discount = 0;

switch (month)
{
    case "May":
    case "October":
        priceForApartment = 65;
        priceForStudio = 50;
        break;

    case "June":
    case "September":
        priceForApartment = 68.7;
        priceForStudio = 75.2;
        break;

    case "July":
    case "August":
        priceForStudio = 76;
        priceForApartment = 77;
        break;

}

if (daysForVacation > 7 && daysForVacation <= 14 && (month == "May" || month == "October"))
{
    priceForStudio *= 0.95; // 5% discount for studio if the conditions are met
}
else if (daysForVacation > 14 && (month == "May" || month == "October"))
{
    priceForStudio *= 0.7; // 30% discont for studio if the conditions are met 
}
else if (daysForVacation > 14 && (month == "June" || month == "September"))
{
    priceForStudio *= 0.8; // 20% discont for studio if the conditions are met
}

if (daysForVacation > 14)
{
    priceForApartment *= 0.9; // 10% discont for apartment anytime when more than 14 days are booked
}

Console.WriteLine($"Apartment: {priceForApartment * daysForVacation:f2} lv.");
Console.WriteLine($"Studio: {priceForStudio * daysForVacation:f2} lv.");