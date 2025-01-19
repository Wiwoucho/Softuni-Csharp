int degrees = int.Parse(Console.ReadLine());
string weather = Console.ReadLine();

string outfit = "";
string shoes = "";

switch (weather)
{
    case "Morning":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        }
        else if (degrees >= 19 && degrees <= 24 )
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        break;

    case "Afternoon":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (degrees >= 19 && degrees <= 24)
        {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else
        {
            outfit = "Swim Suit";
            shoes = "Barefoot";
        }
        break;

    case "Evening":
        if (degrees >= 10 && degrees <= 18)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (degrees >= 19 && degrees <= 24)
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        break;
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}");