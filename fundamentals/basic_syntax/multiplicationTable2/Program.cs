int number = int.Parse(Console.ReadLine());
int multiplyer = int.Parse(Console.ReadLine());


if (multiplyer > 10)
{
    Console.WriteLine($"{number} X {multiplyer} = {number * multiplyer}");
}
else if (multiplyer <= 10)
{
    for (int i = multiplyer; i <= 10; i++)
    {
        Console.WriteLine($"{number} X {i} = {number * i}");
    } 
}