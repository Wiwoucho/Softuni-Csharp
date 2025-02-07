List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

string input = Console.ReadLine();
bool madeChanges = false;


while (input != "end")
{
    string[] commands = input.Split();

    if (commands[0] == "Add")
    {
        madeChanges = true;
        int number = int.Parse(commands[1]);

        numbers.Add(number);
    }
    else if (commands[0] == "Remove")
    {
        madeChanges = true;
        int number = int.Parse(commands[1]);
        numbers.Remove(number);
    }
    else if (commands[0] == "RemoveAt")
    {
        madeChanges = true;
        int index = int.Parse(commands[1]);
        numbers.RemoveAt(index);
    }
    else if (commands[0] == "Insert")
    {
        madeChanges = true;
        int number = int.Parse(commands[1]);
        int index = int.Parse(commands[2]);

        numbers.Insert(index, number);
    }
    else if (commands[0] == "Contains")
    {
        int number = int.Parse(commands[1]);

        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commands[0] == "PrintEven")
    {
        List<int> tempList = numbers.ToList();
        tempList.RemoveAll(x => x % 2 != 0);
        Console.WriteLine(string.Join(" ", tempList));
    }
    else if (commands[0] == "PrintOdd")
    {
        List<int> tempList = numbers.ToList();
        tempList.RemoveAll(x => x % 2 == 0);
        Console.WriteLine(string.Join(" ", tempList));
    }
    else if (commands[0] == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (commands[0] == "Filter")
    {
        string condition = commands[1];
        int number = int.Parse(commands[2]);

        if (condition == "<")
        {
            List<int> tempList = numbers.ToList();
            tempList.RemoveAll(x => x >= number);
            Console.WriteLine(string.Join(" ", tempList));
        }
        else if (condition == ">")
        {
            List<int> tempList = numbers.ToList();
            tempList.RemoveAll(x => x <= number);
            Console.WriteLine(string.Join(" ", tempList));

        }
        else if (condition == ">=")
        {
            List<int> tempList = numbers.ToList();
            tempList.RemoveAll(x => x < number);
            Console.WriteLine(string.Join(" ", tempList));

        }
        else if (condition == "<=")
        {
            List<int> tempList = numbers.ToList();
            tempList.RemoveAll(x => x > number);
            Console.WriteLine(string.Join(" ", tempList));

        }
    }
    input = Console.ReadLine();
}

if (madeChanges)
{
    Console.WriteLine(string.Join(" ", numbers));
}