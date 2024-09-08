using System.Numerics;

double dog_food = 2.5;
int cat_food = 4;

int dog_food_quantity = int.Parse(Console.ReadLine());
int cat_food_quantity = int.Parse(Console.ReadLine());

double total_food = (dog_food * dog_food_quantity) + (cat_food * cat_food_quantity);

Console.WriteLine($"{total_food} lv.");