double budget = double.Parse(Console.ReadLine());
string holidayType = Console.ReadLine();

double moneySpent = 0;
string campOrHotel = "";
string destination = "";

switch (budget) 
{
    case <= 100:
        if (holidayType == "summer")
        {
            moneySpent = budget * 0.3; // will spend 30% of the budget
            destination = "Bulgaria";
            campOrHotel = "Camp";

        }
        else
        {
            moneySpent = budget * 0.7; // will spend 70% of the budget
            destination = "Bulgaria";
            campOrHotel = "Hotel";
        }
        break;

    case > 100 when budget <= 1000:
        if (holidayType == "summer")
        {
            moneySpent = budget * 0.4; // will spend 40% of the budget
            campOrHotel = "Camp";
            destination = "Balkans";
        }
        else
        {
            moneySpent = budget * 0.8; // will spend 80% of the budget
            campOrHotel = "Hotel";
            destination = "Balkans";
        }
            break;

        case > 1000:
        if (holidayType == "summer")
        {
            moneySpent = budget * 0.9; // will spend 90% of the budget
            campOrHotel = "Hotel";
            destination = "Europe";
        }
        else
        {
            moneySpent = budget * 0.9; // will spend 90% of the budget
            campOrHotel = "Hotel";
            destination = "Europe";
        }
        break;
}


Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{campOrHotel} - {moneySpent:f2}");