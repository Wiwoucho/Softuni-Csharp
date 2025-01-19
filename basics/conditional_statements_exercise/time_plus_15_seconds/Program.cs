int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());

int totalTime = (hour * 60) + minute + 15;

if (totalTime / 60 >= 24)
    totalTime = totalTime % 60;

if (totalTime % 60 > 9)
{
    Console.WriteLine($"{(totalTime / 60):0}:{totalTime % 60}");
}
else
{
    Console.WriteLine($"{(totalTime / 60):0}:0{totalTime % 60}");

}

