double mackerel_price_per_kg = double.Parse(Console.ReadLine());
double caca_price_per_kg = double.Parse(Console.ReadLine());
double palamud_kg = double.Parse(Console.ReadLine());
double safrid_kg = double.Parse(Console.ReadLine());
double mussels_kg = double.Parse(Console.ReadLine());

double palamud_price_per_kg = mackerel_price_per_kg * 1.6;
double safrid_price_per_kg = caca_price_per_kg * 1.8;
double mussels_price_per_kg = 7.5;

double total_price_for_palamud = palamud_kg * palamud_price_per_kg;
double total_price_for_safrid = safrid_kg * safrid_price_per_kg;
double total_price_for_mussels = mussels_kg * mussels_price_per_kg;
double total_price_for_all = total_price_for_palamud + total_price_for_safrid + total_price_for_mussels;

Console.WriteLine($"{total_price_for_all:f2}");


