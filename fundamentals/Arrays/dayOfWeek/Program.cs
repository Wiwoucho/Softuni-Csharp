string[] daysOfWeek = { "Monday",
                        "Tuesday", 
                        "Wednesday", 
                        "Thursday", 
                        "Friday", 
                        "Saturday", 
                        "Sunday" };

int number = int.Parse(Console.ReadLine());

if (number > 0 && number <= 7)
{
    Console.WriteLine(daysOfWeek[number - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}