int studentsCount = int.Parse(Console.ReadLine()); // number of the students taking part in the test 

// grades counter 
int excellent = 0;
int veryGood = 0;
int good = 0;
int fail = 0;


// total graddes from every student5
double totalGrades = 0;

for (int i = 0; i < studentsCount; i++)
{
    double studGrade = double.Parse(Console.ReadLine());

    switch (studGrade)
    {
        case >= 5:
            totalGrades += studGrade;
            excellent += 1;
            break;

        case >= 4 and <= 4.99:
            totalGrades += studGrade;
            veryGood += 1;
            break;

        case >= 3 and <= 3.99:
            totalGrades += studGrade;
            good += 1;
            break;

        case < 3:
            totalGrades += studGrade;
            fail += 1;
            break;
    }
}

double totalStudentsCount = excellent + veryGood + good + fail;

// hystogram of the students score 

Console.WriteLine($"Top stundets: {(excellent / totalStudentsCount) * 100:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {(veryGood / totalStudentsCount) * 100:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {(good/ totalStudentsCount) * 100:f2}%");
Console.WriteLine($"Fail: {(fail/ totalStudentsCount) * 100:f2}%");

// mean of all the grades 
Console.WriteLine($"Avarage: {totalGrades / totalStudentsCount:f2}");