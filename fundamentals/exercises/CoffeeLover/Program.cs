List<string> coffees = Console.ReadLine().Split(" ").ToList();

int commandsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < commandsCount; i++)
{
    string[] command = Console.ReadLine().Split(" ").ToArray();

    string option = command[0];

    if (option == "Include")
    {
        string coffee = command[1];
        coffees.Add(coffee);
    }
    else if (option == "Remove")
    {
        int numberOfCoffees = int.Parse(command[2]);

        if (numberOfCoffees > coffees.Count)  continue; 


        if (command[1] == "first")
        {
            coffees.RemoveRange(0, numberOfCoffees);
        }
        else
        {
            coffees.RemoveRange(coffees.Count - numberOfCoffees, numberOfCoffees);
        }
    }
    else if (option == "Prefer")
    {
        int coffeeIndex1 = int.Parse(command[1]);
        int coffeeIndex2 = int.Parse(command[2]);

        if (coffeeIndex1 >= 0 && coffeeIndex1 < coffees.Count && coffeeIndex2 >= 0 && coffeeIndex2 < coffees.Count)
        {
            string temp = coffees[coffeeIndex1];
            coffees[coffeeIndex1] = coffees[coffeeIndex2];
            coffees[coffeeIndex2] = temp;
        }
    }
    else if (option == "Reverse")
    {
        coffees.Reverse();
    }
}

Console.WriteLine("Coffees:");
Console.WriteLine(string.Join(" ", coffees));