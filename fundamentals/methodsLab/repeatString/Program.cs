static string RepeatString(string input, int times)
{
    return $"{string.Concat(Enumerable.Repeat(input, times))}";
}

string word = Console.ReadLine();
int times = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatString(word, times));