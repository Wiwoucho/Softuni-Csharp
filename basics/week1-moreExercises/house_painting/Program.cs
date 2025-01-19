double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

double green_paint = 3.4;
double red_paint = 4.3;
double door_sq = 2.4;
double window_sq = 2.25 * 2;


double side_wall_sq = ((x * y) * 2) - window_sq;
double front_wall_sq = ((x * x) * 2) - door_sq;
double front_roof_sq = ((x * h) / 2) * 2;
double side_roof_sq = (x * y) * 2; 

double total_green_paint_needed = (side_wall_sq + front_wall_sq) / green_paint;
double total_red_paint_needed = (front_roof_sq + side_roof_sq) / red_paint;

Console.WriteLine($"{total_green_paint_needed:f2}\n{total_red_paint_needed:f2}");



