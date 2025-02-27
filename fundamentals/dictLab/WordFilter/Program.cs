namespace WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string[] wordsFilter = words.Where(word => word.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join("\n", wordsFilter));
        }
    }
}
