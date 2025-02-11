string input = Console.ReadLine();

List<int> result = new List<int>();

string[] arrays = input.Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

foreach (string array in arrays)
{
    result.AddRange(array.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse));
}

Console.WriteLine(string.Join(" ", result));
