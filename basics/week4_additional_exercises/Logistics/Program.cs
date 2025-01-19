int deliveryCount = int.Parse(Console.ReadLine());

double totalDeliverySum = 0;


//hystogram for the different type of delivery venhicles
int vanTones= 0;
int truckTones = 0;
int trainTones = 0;



for (int i = 0;  i < deliveryCount; i++)
{
    int deliveryTones = int.Parse(Console.ReadLine());

    switch (deliveryTones)
    {
        case <= 3:
            vanTones += deliveryTones;
            totalDeliverySum += 200 * deliveryTones;
            break;

        case >= 4 and <= 11:
            truckTones += deliveryTones;
            totalDeliverySum += 175 * deliveryTones;
            break;

        case >= 12:
            trainTones += deliveryTones;
            totalDeliverySum += 120 * deliveryTones;
            break;
    }
}

double totalDeliveryTones = vanTones + truckTones + trainTones;

// finding the mean price of all deliveries

Console.WriteLine($"{totalDeliverySum / totalDeliveryTones:f2}");


// finding the percents for each type of delivery 

Console.WriteLine($"{(vanTones / totalDeliveryTones) * 100:f2}%");
Console.WriteLine($"{(truckTones / totalDeliveryTones) * 100:f2}%");
Console.WriteLine($"{(trainTones / totalDeliveryTones) * 100:f2}%");