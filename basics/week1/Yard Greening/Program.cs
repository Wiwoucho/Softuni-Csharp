using System.Numerics;

double price_per_sq = 7.61;
double squares = double.Parse(Console.ReadLine());

double total_without_discount = price_per_sq * squares;
double discount = total_without_discount * 0.18;
double total_with_discount = total_without_discount - discount;

Console.WriteLine($"The final price is: {total_with_discount} lv.\nThe discount is: {discount} lv.");

