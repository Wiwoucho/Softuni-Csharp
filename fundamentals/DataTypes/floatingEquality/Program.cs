double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

double eps = 0.000001;

double result = 0;

if (num1 > num2)
{
    result = num1 - num2;
}
else if (num1 < num2)
{
    result = num2 - num1;
}

if (result <= eps)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}