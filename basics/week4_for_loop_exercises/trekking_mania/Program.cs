int climbersCount = int.Parse(Console.ReadLine());

// how many ppl will exist in each group

int musalaGroup = 0;
int monblanGroup = 0;
int kilimandzharoGroup = 0;
int k2Group = 0;
int everestGroup = 0;


for (int i = 0; i < climbersCount; i++)
{
    int peopleCount = int.Parse(Console.ReadLine());

    switch (peopleCount)
    {
        case <= 5:
            musalaGroup += peopleCount;
            break;
        case >= 6 and <= 12:
            monblanGroup += peopleCount;
            break;
        case >= 13 and <= 25:
            kilimandzharoGroup += peopleCount;
            break;
        case >= 26 and <= 40:
            k2Group += peopleCount;
            break;
        case >= 41:
            everestGroup += peopleCount;
            break;
    }
}


double total = musalaGroup + monblanGroup + kilimandzharoGroup + k2Group + everestGroup;


Console.WriteLine($"{(musalaGroup / total) * 100:f2}%");
Console.WriteLine($"{(monblanGroup / total) * 100:f2}%");
Console.WriteLine($"{(kilimandzharoGroup / total) * 100:f2}%");
Console.WriteLine($"{(k2Group / total) * 100:f2}%");
Console.WriteLine($"{(everestGroup / total) * 100:f2}%");