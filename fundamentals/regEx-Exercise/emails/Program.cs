using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<name>\s[a-zA-Z0-9]+(?:[._-][a-zA-Z0-9]+)*)(?<domain>@(?:[a-zA-Z]+(?:-[a-zA-Z]+)*\.){1,}[a-zA-Z]{2,})";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine($"{match.Groups["name"].Value.Trim()}{match.Groups["domain"].Value}");
        }


    }
}