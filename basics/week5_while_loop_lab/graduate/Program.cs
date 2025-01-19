string name = Console.ReadLine();

int failsCounter = 0;
double sumGrades = 0;

for (int i = 1; i <= 12; i++)
{
    double grade = double.Parse(Console.ReadLine());
    if (grade < 4)
    {
        failsCounter++;
        if (failsCounter == 2)
        {
            Console.WriteLine($"{name} has been excluded at {i-1} grade");
            break;
        }
    }

    sumGrades += grade;
    if (i == 12)
    {
        Console.WriteLine($"{name} graduated. Average grade: {sumGrades / i:f2}");
    }
}
