int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int totalMinutes = hours * 60 + minutes + 30;

int hh = totalMinutes / 60;
int mm = totalMinutes % 60;

if (hh == 24)
{
    hh = 0;
}


Console.WriteLine($"{hh}:{mm:D2}");