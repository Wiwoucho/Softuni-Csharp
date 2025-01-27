int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int maxLenght = 1;
int currentLenght = 1;
int bestElement = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] == numbers[i - 1])
    {
        currentLenght++;
    }
    else
    {
        currentLenght = 1;
    }

    if (currentLenght > maxLenght)
    {
        maxLenght = currentLenght;
        bestElement = numbers[i];
    }
}
Console.WriteLine(string.Join(" ", Enumerable.Repeat(bestElement, maxLenght)));