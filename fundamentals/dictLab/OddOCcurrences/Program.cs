namespace OddOCcurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> wordCount = new ();

            foreach (string word in text)
            {
                string lowerWord = word.ToLower();

                if (!wordCount.ContainsKey(lowerWord))
                {
                    wordCount.Add(lowerWord, 0);
                }
                wordCount[lowerWord]++;
            }

            var result = wordCount.Where(kvp => kvp.Value % 2 != 0).Select(kvp => kvp.Key);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}           
