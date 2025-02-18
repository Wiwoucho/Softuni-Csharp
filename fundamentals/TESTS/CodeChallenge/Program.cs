using System;
using System.Linq;

namespace CodeChallenge
{
    public class NumberProcessor
    {
        static void Main(string[] args)
        {

        }

            public static int[] SortArray(int[] input)
            {
                return input.OrderBy(x => x).ToArray();
            }

            public static int FindMax(int[] input)
            {
                if (input == null || input.Length == 0) throw new ArgumentException("Array cannot be null or empty");
                return input.Max();
            }

            public static int FindSum(int[] input)
            {
                if (input == null) throw new ArgumentNullException(nameof(input), "Array cannot be null");
                return input.Sum();
            }

            public static bool IsEven(int number)
            {
                return number % 2 == 0;
            }
        
    }
}
