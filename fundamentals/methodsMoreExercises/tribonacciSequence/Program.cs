int fibNumber = int.Parse(Console.ReadLine());

static void TribonacciSeq(int num)
{
    int[] sequence = new int[num];

    

    for (int i = 0; i < num; i++)
    {
        if (i < 2)
        {
            sequence[i] = 1;
        }
        else if (i == 2)
        {
            sequence[i] = 2;
        }
        else
        {
            sequence[i] = sequence[i-1 ] + sequence[i-2] + sequence[i-3];
        }

    }
    Console.WriteLine(string.Join(" ", sequence));
}

TribonacciSeq(fibNumber);