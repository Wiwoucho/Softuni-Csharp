int commandsToFollow = int.Parse(Console.ReadLine());

List<string> names = new List<string>();

for (int i = 0; i < commandsToFollow; i++)
{
    string[] commands = Console.ReadLine().Split(' ', 2).ToArray();
    string name = commands[0];
    string action = commands[1];

    if (action == "is going!")
    {
        if (!names.Contains(name))
        {
            names.Add(name);
        }
        else
        {
            Console.WriteLine($"{name} is already in the list!");
        }
    }
    else
    {
        if (names.Contains(name))
        {
            names.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

Console.WriteLine(string.Join(Environment.NewLine, names));