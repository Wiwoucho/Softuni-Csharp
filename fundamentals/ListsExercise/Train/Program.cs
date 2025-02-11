List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int wagonMaxCapacity = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

while (command != "end")
{
    if (command.Split()[0] == "Add")
    {
        int passengers = int.Parse(command.Split()[1]);
        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(command);
        
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengers <= wagonMaxCapacity)
            {
                wagons[i] += passengers;
                break;
            }
        }
        
        
    }
    command = Console.ReadLine();
}

Console.Write($"{string.Join(" ", wagons)}");