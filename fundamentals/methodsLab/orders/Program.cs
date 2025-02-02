static double Orders(string input, double number)
{
    double price = 0;
    
    switch (input)
    {
        case "coffee":
            price = 1.50;
            break;
        case "water":
            price = 1.00;
            break;
        case "coke":
            price = 1.40;
            break;
        case "snacks":
            price = 2.00;
            break;
    }

    return (number * price);
}

string input = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

Console.WriteLine($"{Orders(input, quantity):F2}");