using System.Numerics;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string command = Console.ReadLine();



while (command != "End")
{
    string operation = command.Split()[0];


    if (operation == "Add")
    {
        int number = int.Parse(command.Split()[1]);
        numbers.Add(number);
    }

    else if (operation == "Insert")
    {
        int number = int.Parse(command.Split()[1]);
        int index = int.Parse(command.Split()[2]);

        if (index < 0 || index > numbers.Count - 1)
        {
            Console.WriteLine($"Invalid index");
            command = Console.ReadLine();
            continue;
        }

        numbers.Insert(index, number);
    }

    else if (operation == "Remove")
    { 
        int index = int.Parse(command.Split()[1]); ;

        if (index < 0 || index > numbers.Count - 1)
        {
            Console.WriteLine($"Invalid index");
            command = Console.ReadLine();
            continue;
        }

        numbers.RemoveAt(index);
    }

    else if (command.Substring(0, 10) == "Shift left")
    {
        int counter = int.Parse(command.Split()[2]);
        for (int i = 0; i < counter; i++)
        {
            int firstNumber = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(firstNumber);

        }

    }

    else if (command.Substring(0, 11) == "Shift right")
    {
        int counter = int.Parse(command.Split()[2]);
        for (int i = 0; i < counter; i++)
        {
            int lastNumber = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            numbers.Insert(0, lastNumber);
        }

    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));