int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    bool topNumber = true;

    for (int j = i +1; j < numbers.Length; j++)
    {
        if (numbers[i] <= numbers[j])
        {
            topNumber = false;
            break;
        }
    }
    if (topNumber)
    {
        Console.Write($"{numbers[i]} ");
    }
}