int pages = int.Parse(Console.ReadLine());
int pages_per_hour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int pages_per_day = pages / pages_per_hour;
int hours_per_day = pages_per_day / days;

Console.WriteLine(hours_per_day);
