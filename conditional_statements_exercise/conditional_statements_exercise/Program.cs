int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalTime = firstTime + secondTime + thirdTime;

if (totalTime % 60 > 9)
{
    Console.WriteLine($"{totalTime / 60}:{totalTime % 60}");
}
else
{
    Console.WriteLine($"{totalTime / 60}:0{totalTime % 60}");

}