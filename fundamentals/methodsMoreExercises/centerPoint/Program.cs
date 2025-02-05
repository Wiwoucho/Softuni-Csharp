double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());


static double[] FindClosestCordinatesToZero(double x1, double y1, double x2, double y2)
{
    double[] result = new double[2];


    double firstPair = Math.Pow(x1, 2) + Math.Pow(y1, 2);
    double secondPair = Math.Pow(x2, 2) + Math.Pow(y2, 2);

    if (firstPair <= secondPair)
    {
        result[0] =  x1;
        result[1] =  y1;
    }
    else
    {
        result[0] =  x2;
        result[1] =  y2;
    }

    return result;
}

Console.WriteLine($"({string.Join(", ", FindClosestCordinatesToZero(x1,y1,x2,y2))})");