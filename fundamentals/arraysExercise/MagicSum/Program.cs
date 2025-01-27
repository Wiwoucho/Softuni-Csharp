int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNumber = int.Parse(Console.ReadLine());

for  (int i = 0; i < number.Length; i++)
{
    for (int j = i + 1; j < number.Length; j++)
    {
        if (number[i] + number[j] == magicNumber)
        {
            Console.WriteLine($"{number[i]} {number[j]}");
        }
    }
}