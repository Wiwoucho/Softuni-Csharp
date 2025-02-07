int n = int.Parse(Console.ReadLine());
List<string> strings = new List<string>();


for (int i = 0; i < n; i++)
{
    strings.Add(Console.ReadLine());
}

strings.Sort();

foreach(string s in strings)
{
    Console.WriteLine($"{strings.IndexOf(s) + 1}.{s}");
}