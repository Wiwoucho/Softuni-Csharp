int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

for (int i = firstNum; i <= secondNum; i++)
{
    int sumOdd = 0;
    int sumEven = 0;

    for (int j = 0; j < i.ToString().Length; j++)
    {
        int currentDigit = int.Parse(i.ToString()[j].ToString());

        if (j % 2 == 0)
        {
            sumEven += currentDigit;
        }
        else
        {
            sumOdd += currentDigit;
        }

    }
    if (sumOdd == sumEven)
    {
        Console.Write($"{i} ");
    }
}