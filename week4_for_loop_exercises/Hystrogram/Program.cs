using System.Numerics;

int n = int.Parse(Console.ReadLine());

double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;
double p5 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    if (number < 200)
    {
        p1 += 1;
    }
    else if (number >= 200 && number <= 399)
    {
        p2 += 1;
    }
    else if (number >= 400 && number <= 599){
        p3 += 1;
    }
    else if (number >= 600 && number <= 799)
    {
        p4 += 1;
    }
    else
    {
        p5 += 1;
    }
}


double sum = p1 + p2 + p3 + p4 + p5;

Console.WriteLine($"{(p1 / sum) * 100:f2}%");
Console.WriteLine($"{(p2 / sum) * 100:f2}%");
Console.WriteLine($"{(p3 / sum) * 100:f2}%");
Console.WriteLine($"{(p4 / sum) * 100:f2}%");
Console.WriteLine($"{(p5 / sum) * 100:f2}%");