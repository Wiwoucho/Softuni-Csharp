string fuelType = Console.ReadLine();
double fuelLiters = double.Parse(Console.ReadLine());
string isHavingDiscountCard = Console.ReadLine();

double fuelPrice = 0.0;


if (fuelType == "Gasoline")
{
    fuelPrice = 2.22;
}
else if (fuelType == "Gas")
{
    fuelPrice = 0.93;
}
else
{
    fuelPrice = 2.33;

}



if (isHavingDiscountCard == "Yes")
{
    if (fuelType == "Gasoline")
    {
        fuelPrice -= 0.18;
    }
    else if (fuelType == "Gas")
    {
        fuelPrice -= 0.08;
    }
    else
    {
        fuelPrice -= 0.12;

    }
}

double totalCost = fuelLiters * fuelPrice;

if (fuelLiters >= 20 && fuelLiters <= 25)
{
    totalCost *= 0.92; // getting 8% discount between 20 and 25 liters
}
else if(fuelLiters > 25)
{
    totalCost *= 0.9; // getting 10% discount for more than 25 liters
}

Console.WriteLine($"{totalCost:f2} lv.");