double balance = 0;

string text = Console.ReadLine();

while (text != "NoMoreMoney")
{
    if (double.Parse(text) < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    double money = double.Parse(text);
    balance += money;
    Console.WriteLine($"Increase: {money:f2}");

    text = Console.ReadLine();
}

Console.WriteLine($"Total: {balance:f2}");