string city = Console.ReadLine();
double sales_profit = double.Parse(Console.ReadLine());

double bonusProfitPercent = 0;
bool isTownInList = false;

if (sales_profit > 0 )
{

    switch (city)
    {
        case "Sofia":
            switch (sales_profit)
            {
                case >= 0 and <= 500: bonusProfitPercent = 0.05; break;
                case >= 500 and <= 1000: bonusProfitPercent = 0.07; break;
                case >= 1000 and <= 10000: bonusProfitPercent = 0.08; break;
                case > 10000: bonusProfitPercent = 0.12; break;
            }
            isTownInList = true;
            break;
           

        case "Varna":
            switch (sales_profit)
            {
                case >= 0 and <= 500: bonusProfitPercent = 0.045; break;
                case >= 500 and <= 1000: bonusProfitPercent = 0.075; break;
                case >= 1000 and <= 10000: bonusProfitPercent = 0.1; break;
                case > 10000: bonusProfitPercent = 0.13; break;
            }
            isTownInList = true;
            break;

        case "Plovdiv":
            switch (sales_profit)
            {
                case >= 0 and <= 500: bonusProfitPercent = 0.055; break;
                case >= 500 and <= 1000: bonusProfitPercent = 0.08; break;
                case >= 1000 and <= 10000: bonusProfitPercent = 0.12; break;
                case > 10000: bonusProfitPercent = 0.145; break;
            }
            isTownInList = true;
            break;
        default: Console.WriteLine("error"); break;
    }
}
else
{
    Console.WriteLine("error");
}

if (isTownInList)
{
    Console.WriteLine($"{sales_profit * bonusProfitPercent:f2}");
}

