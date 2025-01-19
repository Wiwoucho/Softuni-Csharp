int hourForTheTest = int.Parse(Console.ReadLine());
int minutesForTheTest = int.Parse(Console.ReadLine());
int arrivingStudentHour = int.Parse(Console.ReadLine());
int arrivesStudentMinutes = int.Parse(Console.ReadLine());

int hoursAndMinutesOfArriving = arrivingStudentHour * 60 + arrivesStudentMinutes;
int hoursAndMinutesOfTest = hourForTheTest * 60 + minutesForTheTest;

if (hoursAndMinutesOfArriving > hoursAndMinutesOfTest)
{
    Console.WriteLine("Late");

    int difference = hoursAndMinutesOfArriving - hoursAndMinutesOfTest;

    if (difference >= 60)
    {
        int hoursLate = difference / 60;
        int minutesLate = difference % 60;
        Console.WriteLine($"{hoursLate}:{minutesLate:D2} hours after the start");
    }
    else
    {
        Console.WriteLine($"{difference} minutes after the start");
    }
}
else if (hoursAndMinutesOfTest - hoursAndMinutesOfArriving <= 30)
{
    Console.WriteLine("On time");

    int difference = hoursAndMinutesOfTest - hoursAndMinutesOfArriving;

    if (difference != 0)
    {
        Console.WriteLine($"{difference} minutes before the start");
    }
}
else
{
    Console.WriteLine("Early");

    int difference = hoursAndMinutesOfTest - hoursAndMinutesOfArriving;

    if (difference >= 60)
    {
        int hoursEarly = difference / 60;
        int minutesEarly = difference % 60;
        Console.WriteLine($"{hoursEarly}:{minutesEarly:D2} hours before the start");
    }
    else
    {
        Console.WriteLine($"{difference} minutes before the start");
    }
}
