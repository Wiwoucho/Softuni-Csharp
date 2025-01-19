
double magnoliasCount = double.Parse(Console.ReadLine()) * 3.25; // 3.25 is the price per single magnolia
double ziumbiulCount = double.Parse(Console.ReadLine()) * 4; //4 is the price per single ziumbul
double roseCount = double.Parse(Console.ReadLine()) * 3.5; // 3.5 is the price per single rose
double cactusCount = double.Parse(Console.ReadLine()) * 8; // 8 is the price per single cactus
double giftPrice = double.Parse(Console.ReadLine()); 

double totalSum = magnoliasCount + ziumbiulCount + roseCount + cactusCount;
double VATonTotalSum = totalSum * 0.05;
totalSum -= VATonTotalSum;

if (totalSum >= giftPrice)
{
    Console.WriteLine($"She is left with {Math.Floor(totalSum - giftPrice)} leva.");
}

else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalSum)} leva.");
}
