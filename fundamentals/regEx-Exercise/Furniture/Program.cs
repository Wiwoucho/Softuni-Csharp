using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string furniture = Console.ReadLine();
        string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
        double totalPrice = 0;
        List<string> items = new();

        while (furniture != "Purchase")
        {
            Match match = Regex.Match(furniture, pattern);
            if (match.Success)
            {
                string item = match.Groups["name"].Value;
                var price = match.Groups["price"].Value;
                var quantity = match.Groups["quantity"].Value;

                items.Add(item);

                totalPrice += int.Parse(quantity) * double.Parse(price);
            }

            furniture = Console.ReadLine();
        }

        Console.WriteLine("Bought furniture:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Total money spend: {totalPrice:F2}");
    }
}