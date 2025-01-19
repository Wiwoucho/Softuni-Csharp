int assessors = int.Parse(Console.ReadLine());
string presentationName = Console.ReadLine();

double totalGrades = 0;
int totalGradesCounter = 0;


while (presentationName != "Finish")
{
    double currentGrade = 0;
    int currentGradeCounter = 0;


    for (int i = 0; i < assessors; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        currentGradeCounter++;
        currentGrade += grade;
    }

    totalGrades += currentGrade / currentGradeCounter;
    totalGradesCounter ++;
    Console.WriteLine($"{presentationName} - {currentGrade / currentGradeCounter:2f}.");
    
    presentationName = Console.ReadLine();
}

Console.WriteLine($"Student's final assessment is {totalGrades / totalGradesCounter:2f}.");
