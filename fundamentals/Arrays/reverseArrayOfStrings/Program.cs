string[] chars = Console.ReadLine().Split(" ");

for (int i = 0; i < chars.Length / 2; i++)
{
    string temp = chars[i];
    chars[i] = chars[chars.Length - 1 - i];
    chars[chars.Length - 1 - i] = temp;
}

Console.WriteLine(string.Join(" ", chars));