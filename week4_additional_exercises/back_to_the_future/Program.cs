double moneyInhert = double.Parse(Console.ReadLine());
int yearToLive = int.Parse(Console.ReadLine());

int ivanAge = 18;
int startingYear = 1800;


for (int currentYear = startingYear; currentYear <= yearToLive; currentYear++)
{
    if (currentYear % 2 == 0)
    {
        moneyInhert -= 12000;
    }
    else
    {
        moneyInhert -= 12000 + (50 * ivanAge);
    }
    
    ivanAge++;
}


if (moneyInhert < 0)
{
    Console.WriteLine($"He will need {Math.Abs(moneyInhert):f2} dollars to survive.");
}
else
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInhert:f2} dollars left.");
}