using System.Numerics;

double budget = double.Parse(Console.ReadLine());
int statists_number = int.Parse(Console.ReadLine());
double cost_per_statist = double.Parse(Console.ReadLine());

double decoration = budget * 0.1; // decoration for the movie is 10% of the budget

if (statists_number > 150)
{
    cost_per_statist *= 0.9; // 10% discount for more than 150 statists
}

double total_costs = (statists_number * cost_per_statist) + decoration;

if (total_costs > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {total_costs - budget:f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - total_costs:f2} leva left.");
}