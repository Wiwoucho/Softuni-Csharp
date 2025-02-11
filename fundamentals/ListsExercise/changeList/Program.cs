List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

static List<int> Delete(List<int> numbers, int numberToDelete)
{
    numbers.RemoveAll(x => x == numberToDelete);
    return numbers;
}

string command = Console.ReadLine();

while (command != "end")
{
    if (command.Split()[0] == "Delete")
    {
        int number = int.Parse(command.Split()[1]);
        numbers = Delete(numbers, number);
    }
    else
    {
        int index = int.Parse(command.Split()[2]);
        int element = int.Parse(command.Split()[1]);
        numbers.Insert(index, element);
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));