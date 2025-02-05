double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x3 = double.Parse(Console.ReadLine());
double y3 = double.Parse(Console.ReadLine());
double x4 = double.Parse(Console.ReadLine());
double y4 = double.Parse(Console.ReadLine());

static (double, double)[] ClosestPairToZero(double x1, double y1, double x2, double y2, double x3,double y3, double x4, double y4)
{
    (double, double)[] result = new (double, double)[2];

    double firstPair = Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(x2, 2) + Math.Pow(y2, 2);
    double secondPair = Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(x4, 2) + Math.Pow(y4, 2);


    if (x1 % 1 == 0 && x2 % 1 == 0 && x3 % 1 == 0 && x4 % 1 == 0 && y1 % 1 == 0 && y2 % 1 == 0 && y3 % 1 == 0 && y4 % 1 == 0)
    {
        if (firstPair >= secondPair)
        {
            result[1] = (x1, y1);
            result[0] = (x2, y2);
        }
        else
        {
            result[1] = (x3, y3);
            result[0] = (x4, y4);
        }
    }
    else
    {
        if (firstPair >= secondPair)
        {
            result[0] = (x1, y1);
            result[1] = (x2, y2);
        }
        else
        {
            result[0] = (x3, y3);
            result[1] = (x4, y4);
        }
    }

    return result;
}

Console.WriteLine(string.Join("", ClosestPairToZero(x1, y1, x2, y2, x3, y3, x4, y4)));