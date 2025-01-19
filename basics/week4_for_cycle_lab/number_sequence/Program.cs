int n = int.Parse(Console.ReadLine());

List<int> numbers =  new List<int>();

for (int i = 0; i < n; i++)
{
    numbers.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine($"Max number: {numbers.Max()}");
Console.WriteLine($"Min number: {numbers.Min()}");