﻿string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double product_price = 0;


if (city == "Sofia")
{
    switch (product)
    {
        case "coffee":
            product_price = 0.50;
            break;
        case "water":
            product_price = 0.80;
            break;
        case "beer":
            product_price = 1.2;
            break;
        case "sweets":
            product_price = 1.45;
            break;
        case "peanuts":
            product_price = 1.60;
            break;
            
    }

}

else if (city == "Plovdiv")
{
    switch (product)
    {
        case "coffee":
            product_price = 0.40;
            break;
        case "water":
            product_price = 0.70;
            break;
        case "beer":
            product_price = 1.15;
            break;
        case "sweets":
            product_price = 1.30;
            break;
        case "peanuts":
            product_price = 1.50;
            break;

    }
}
else if (city == "Varna")
{
    switch (product)
    {
        case "coffee": product_price = 0.45; break;
        case "water": product_price = 0.70; break;
        case "beer": product_price = 1.10; break;
        case "sweets": product_price = 1.35; break;
        case "peanuts": product_price = 1.55; break;

    }
}

Console.WriteLine(product_price * quantity);