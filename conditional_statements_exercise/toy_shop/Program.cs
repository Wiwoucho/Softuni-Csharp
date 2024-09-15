double vacation_price = double.Parse(Console.ReadLine());
int puzzle_count = int.Parse(Console.ReadLine());
int doll_count = int.Parse(Console.ReadLine());
int bear_count = int.Parse(Console.ReadLine());
int minion_count = int.Parse(Console.ReadLine());
int truck_count = int.Parse(Console.ReadLine());

int toy_count = puzzle_count + doll_count + bear_count + minion_count + truck_count;
double puzzle_price = 2.6;
double doll_price = 3;
double bear_price = 4.10;
double minion_price = 8.2;
double truck_price = 2;

double total_money = (puzzle_count * puzzle_price) + (doll_count * doll_price) + (bear_count * bear_price) + (minion_count * minion_price) + (truck_count * truck_price);

if (toy_count >= 50)
{
    total_money *= 0.75; // 25% discount if more than 49 toys
}

total_money *= 0.9; // 10% from the total cost going for rent


if (total_money >= vacation_price)
{
    Console.WriteLine($"Yes! {total_money - vacation_price:0.00} lv left.");
}

else
{
    Console.WriteLine($"Not enough money! {vacation_price - total_money:0.00} lv needed.");
}
