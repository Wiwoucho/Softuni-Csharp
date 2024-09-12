int v = int.Parse(Console.ReadLine());
int p1_fill_per_hour = int.Parse(Console.ReadLine());
int p2_fill_per_hour = int.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double p1_litres_filled = p1_fill_per_hour * h;
double p2_litres_filled = p2_fill_per_hour * h;
double total_litres_filled = p1_litres_filled + p2_litres_filled;

double total_percentage_filled = ((p1_litres_filled / v) * 100) + (p2_litres_filled / v) * 100;
double p1_percentage_filled = (p1_litres_filled / total_litres_filled) * 100;
double p2_percentage_filled = (p2_litres_filled / total_litres_filled) * 100;

if (total_percentage_filled > 100)
    {
    double pool_overflow = total_litres_filled - v;
    Console.WriteLine($"For {h} hours the pool overflows with {pool_overflow} liters.");
    }
else
    {

    Console.WriteLine($"The pool is {total_percentage_filled}% full. Pipe 1: {p1_percentage_filled:f2}%. Pipe 2: {p2_percentage_filled:f2}%.");
    }

