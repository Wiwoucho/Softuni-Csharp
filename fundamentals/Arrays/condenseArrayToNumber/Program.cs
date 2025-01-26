int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


while (numbers.Length > 1)
{
    int[] currentCondense = new int[numbers.Length - 1];

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int currentEelement = numbers[i];
        int nextElement = numbers[i + 1];

        currentCondense[i] = currentEelement + nextElement;
    }
     numbers = currentCondense;
}

Console.WriteLine(numbers[0]);