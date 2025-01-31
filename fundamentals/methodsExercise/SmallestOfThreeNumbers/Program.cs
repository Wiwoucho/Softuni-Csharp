int[] numbers = new int[3];

for  (int i = 0; i < 3; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(numbers.Min());