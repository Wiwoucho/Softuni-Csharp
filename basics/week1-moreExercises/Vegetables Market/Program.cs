double price_per_kg_vegetables = double.Parse(Console.ReadLine());
double price_per_kg_fruits = double.Parse(Console.ReadLine());
double vegetables_weight = double.Parse(Console.ReadLine());
double fruits_weight = double.Parse(Console.ReadLine());

double total_in_bgn = (price_per_kg_fruits * fruits_weight) + (price_per_kg_vegetables * vegetables_weight);
double total_in_eur = total_in_bgn / 1.94;

Console.WriteLine($"{total_in_eur:F2}");
