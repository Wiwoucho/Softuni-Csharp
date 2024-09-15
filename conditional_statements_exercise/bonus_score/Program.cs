using System.Numerics;

int number = int.Parse(Console.ReadLine());
double bonus_points = 0;

if (number > 1000)
{
     bonus_points = number * 0.1;
}
else if (number > 100)
{
     bonus_points = number * 0.2;
}
else
{
     bonus_points += 5;
}

if (number % 2 == 0)
{
    bonus_points += 1;
}
else if (number % 10 == 5)
{
    bonus_points += 2;
}

double total_points = number + bonus_points;

Console.WriteLine($"{bonus_points}\n{total_points}");