string dayOfTheWeek = Console.ReadLine();

switch (dayOfTheWeek)
{
    case "Monday" or "Tuesday" or "Friday":
        Console.WriteLine(12);
        break;

    case "Wednesday" or "Thursday":
        Console.WriteLine(14);
        break;
    case "Saturday" or "Sunday":
        Console.WriteLine(16);
        break;  
}