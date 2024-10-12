int totalFloors = int.Parse(Console.ReadLine());
int roomsPerFloor  = int.Parse(Console.ReadLine());

for (int floor = totalFloors; floor >= 1; floor--)
{
    for (int room = 0; room < roomsPerFloor; room++)
    {
        if (floor == totalFloors)
        {
            Console.Write($"L{floor}{room} ");
        }
        else if (floor % 2 == 0)
        {
            Console.Write($"O{floor}{room} ");
        }
        else
        {
            Console.Write($"A{floor}{room} ");
        }
    }
    Console.WriteLine($"");
}