using System.ComponentModel;

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool areEqual = false;

for  (int i = 0; i < numbers.Length; i++)
{
    int sumLeft = 0;
    int sumRight = 0;
    
    if (i > 0)
    {
        for (int j = i - 1; j >= 0; j--)
        {
            sumLeft += numbers[j];
        }
    }

    for (int k = i + 1; k < numbers.Length; k++)
    {
        sumRight += numbers[k];
    }

    if (sumLeft == sumRight)
    {
        Console.WriteLine(i);
        areEqual = true;
        break;
    }
}

if (!areEqual)
{
    Console.WriteLine("no");
}