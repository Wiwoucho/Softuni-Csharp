double lilyAge = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

double lilySavedMoney = 0;
double lilyMoneyGivenForBirthday = 10;
double moneyFromToys = 0; // she recieve toy on ever odd number of her age

for (int i = 1; i <= lilyAge; i++)
{
    if (i % 2 == 0)   // she recieving double money on every even number of her age 
    {
        lilySavedMoney += lilyMoneyGivenForBirthday;
        lilyMoneyGivenForBirthday += 10;
        lilySavedMoney -= 1; // her brother stealing 1 dollar on every even number of her age
    }
    else
    {
        moneyFromToys += toyPrice;
    }
    
}


lilySavedMoney += moneyFromToys;

if (lilySavedMoney >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {lilySavedMoney - washingMachinePrice:f2}");
}
else
{
    Console.WriteLine($"No! {washingMachinePrice - lilySavedMoney:f2}");
}