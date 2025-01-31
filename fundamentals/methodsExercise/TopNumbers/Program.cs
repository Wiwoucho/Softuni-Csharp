using System.Globalization;

int number = int.Parse(Console.ReadLine());


static void TopNumber(int number)
{
    for (int i = 9; i < number; i++)
    {
        if (SumIntegers(i) % 8 == 0)
        {
            if (HaveOddDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}

static int SumIntegers(int number)
{
    int sum = 0;

    string num = string.Join("", number.ToString().Split());

    for (int i = 0; i < num.Length; i++)
    {
        sum += num[i] - '0';
    }
    return sum;
}

static bool HaveOddDigit(int number)
{
    string num = string.Join("", number.ToString().Split());

    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 != 0)
        {
            return true;
        }
    }

        return false;
}

TopNumber(number);