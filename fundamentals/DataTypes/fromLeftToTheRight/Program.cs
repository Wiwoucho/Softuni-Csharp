using System;

class Program
{
    static int SumOfDigits(long number)
    {
        int sum = 0;
        foreach (char digit in Math.Abs(number).ToString())
        {
            sum += int.Parse(digit.ToString());
        }
        return sum;
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            long left = long.Parse(input[0]);
            long right = long.Parse(input[1]);

            if (left > right)
            {
                Console.WriteLine(SumOfDigits(left));
            }
            else
            {
                Console.WriteLine(SumOfDigits(right));
            }
        }
    }
}
