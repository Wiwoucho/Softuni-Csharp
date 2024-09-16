double budget = double.Parse(Console.ReadLine());
int videocard_number = int.Parse(Console.ReadLine());
int processors_number = int.Parse(Console.ReadLine());
int ram_memory_number = int.Parse(Console.ReadLine());

int videocard_total_price= videocard_number * 250; // 250 is the videocard price per unit

double processor_price = videocard_total_price * 0.35; // 35% of the total price for videocards is the price for a single processor
double ram_memory_price = videocard_total_price * 0.1; // 10% of the total price for videocards is the price for a single RAM memory

double total_price_for_proccesors = processors_number * processor_price;
double total_price_for_ram_memory = ram_memory_number * ram_memory_price;

double total_all_together = videocard_total_price + total_price_for_proccesors + total_price_for_ram_memory;

if (videocard_number > processors_number)
{
    total_all_together *= 0.85; // 15% discount for having more videocards than processors
}

if (total_all_together > budget)
{
    Console.WriteLine($"Not enough money! You need {total_all_together - budget:f2} leva more!");
}

else
{
    Console.WriteLine($"You have {budget - total_all_together:f2} leva left!");
}