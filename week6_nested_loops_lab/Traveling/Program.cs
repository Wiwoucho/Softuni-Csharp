while (true)
{
    string destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    double neededBudget = double.Parse(Console.ReadLine());
    double savedMoney = 0;

    while ( savedMoney < neededBudget)
    {
        savedMoney += double.Parse(Console.ReadLine());

    }

    Console.WriteLine($"Going to {destination}!");
}