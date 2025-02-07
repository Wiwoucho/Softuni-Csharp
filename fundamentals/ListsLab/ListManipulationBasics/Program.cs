List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] commands = input.Split();

    if (commands[0] == "Add")
    {
        int number = int.Parse(commands[1]);

        numbers.Add(number);
    }
    else if (commands[0] == "Remove")
    {
        int number = int.Parse(commands[1]);
        numbers.Remove(number);
    }
    else if (commands[0] == "RemoveAt")
    {
        int index = int.Parse(commands[1]);
        numbers.RemoveAt(index);
    }
    else if (commands[0] == "Insert")
    {
        int number = int.Parse(commands[1]);
        int index = int.Parse(commands[2]);

        numbers.Insert(index, number); 
    }
    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));