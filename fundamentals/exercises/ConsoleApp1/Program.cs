int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
int workers = int.Parse(Console.ReadLine());
int targetBiscuits = int.Parse(Console.ReadLine());

int myProduction = 0;


for (int i = 1; i <= 30; i++)
{
    int biscuitsProducedToday = biscuitsPerDayPerWorker * workers;

    if (i % 3 == 0)
    {
        biscuitsProducedToday = (int) Math.Floor(biscuitsProducedToday * 0.75);
    }

    myProduction += biscuitsProducedToday;
}

double percentage = (double)myProduction / targetBiscuits * 100;

if (myProduction >= targetBiscuits)
{
    Console.WriteLine($"You have produced {myProduction} biscuits for the past month.");
    Console.WriteLine($"You produce {percentage - 100:F2} percent more biscuits.");
}
else
{
    Console.WriteLine($"You have produced {myProduction} biscuits for the past month.");
    Console.WriteLine($"You produce {100 - percentage:F2} percent less biscuits.");
}