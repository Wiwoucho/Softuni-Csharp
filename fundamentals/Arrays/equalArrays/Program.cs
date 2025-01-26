int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

int sum = 0;
bool identical = true;

for  (int i = 0; i < arrayOne.Length; i++)
{
    int elementArrayOne = arrayOne[i];
    int elementArrayTwo = arrayTwo[i];

    if (elementArrayOne == elementArrayTwo)
    {
        sum += elementArrayOne;
    }
    else
    {
        identical = false;
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        break;
    }
}

if (identical)
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}