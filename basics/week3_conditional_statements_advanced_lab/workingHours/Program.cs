int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

switch (dayOfWeek)
{
    case "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday" or "Saturday":
        if (hour >= 10 && hour <= 18)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
        break;

    case "Sunday": Console.WriteLine("closed"); break;
}  