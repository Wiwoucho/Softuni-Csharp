static double MathPower(double number, double power)
{
    double result = number;

    for (int i = 1; i < power; i++)
    {
        result *= number;
    }
    
    return result;
}


double number = double.Parse(Console.ReadLine());
double power = double.Parse(Console.ReadLine());

Console.WriteLine(MathPower(number, power));