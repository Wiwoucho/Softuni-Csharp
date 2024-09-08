int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()) / 100;

double area_of_aquarium = length * width * height;
double liters_of_water = area_of_aquarium * 0.001;
double water_needed = liters_of_water * (1 - percent);

Console.WriteLine(water_needed);