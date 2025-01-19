double r = double.Parse(Console.ReadLine());

double perimeter = 2 * Math.PI * r;
double area = Math.PI * Math.Pow(r, 2);

Console.WriteLine($"{area:f2}\n{perimeter:f2}");
