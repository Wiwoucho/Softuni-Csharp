int days = int.Parse(Console.ReadLine());
double pets_food_kg = double.Parse(Console.ReadLine());
double dog_food_kg = double.Parse(Console.ReadLine());
double cat_food_kg = double.Parse(Console.ReadLine());
double turtle_food_gr = double.Parse(Console.ReadLine());

double total_food_kg = (dog_food_kg + cat_food_kg + (turtle_food_gr / 1000)) * days;

if  (pets_food_kg >= total_food_kg)
{
    Console.WriteLine($"{Math.Floor(pets_food_kg - total_food_kg)} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(total_food_kg - pets_food_kg)} more kilos of food are needed.");
}