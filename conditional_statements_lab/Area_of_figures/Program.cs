string figure = Console.ReadLine();

if (figure == "square")

{
    double side = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(Math.Pow(side, 2)):0.000}");
}

else if  (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(a * b):0.000}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(Math.PI * Math.Pow(radius, 2)):0.000}");
}
else
{
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine($"{((b * h) / 2):0.000}");
}