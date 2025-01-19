string dayOfTheWeek = Console.ReadLine();

switch (dayOfTheWeek)
{
	case "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday":
        Console.WriteLine("Working day");
		break;
    case "Saturday" or "Sunday":
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Error");
        break;
}