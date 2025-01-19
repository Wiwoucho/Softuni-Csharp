double nailon_per_sq = 1.5;
double paint_per_liter = 14.50;
double razreditel_per_liter = 5;

double nailon_quantity = double.Parse(Console.ReadLine()) + 2;
double paint_quantity = double.Parse(Console.ReadLine()) * 1.1;
double razreditel_quantity = double.Parse(Console.ReadLine());
int workers_hours = int.Parse(Console.ReadLine());

double expenses = (nailon_quantity * nailon_per_sq) + (paint_quantity * paint_per_liter) + (razreditel_quantity * razreditel_per_liter) + 0.40;
double worker_pay = (expenses * 0.3) * workers_hours;

Console.WriteLine(expenses + worker_pay);
