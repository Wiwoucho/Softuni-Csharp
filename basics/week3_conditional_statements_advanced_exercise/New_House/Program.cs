string flowerType = Console.ReadLine();
int flowerCount = int.Parse(Console.ReadLine());
double budget =  double.Parse(Console.ReadLine());

// flowers prices 
double flowerPrice = 0;
double discount = 0;

switch (flowerType)
{
    case "Roses":
        flowerPrice = 5; // price per single rose 
        if (flowerCount > 80)
        {
            discount = 0.9; // 10% discont if count is greater than 80
        }
        break;
    case "Dahlias":
        flowerPrice = 3.8; // price per single Dahlia
        if (flowerCount > 90)
        {
            discount = 0.85; // 15% discont if count is greater than 90
        }
        break;
    case "Tulips":
        flowerPrice = 2.8; // price per single Tulip
        if (flowerCount > 80)
        {
            discount = 0.85; // 15% discont if count is greater than 90
        }
        break;
    case "Narcissus":
        flowerPrice = 3; // price per single Narcissus
        if (flowerCount < 120)
        {
            discount = 1.15; // price goes up if the count is less than 120
        }
        break;
    case "Gladiolus":
        flowerPrice = 2.5; // price per single Narcissus
        if (flowerCount < 80)
        {
            discount = 1.2; // price goes up if the count is less than 80
        }
        break;
}


double totalSum = flowerCount * flowerPrice;
if (discount != 0)
{
   totalSum *= discount;
}

if (budget >= totalSum)
{
    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - totalSum:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {totalSum - budget:f2} leva more.");
}