namespace CountingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> numAndOccur = new();

            foreach (int number in numbers)
            {
                if (!numAndOccur.ContainsKey(number))
                {
                    numAndOccur.Add(number, 0);
                }

                numAndOccur[number]++;
            }

            foreach ((int key, int value)in numAndOccur)
            {
                Console.WriteLine($"{key} -> {value}");
            }


        }
    }
}
 