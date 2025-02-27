namespace WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms = new();

            for (int i = 0; i < n; i++)
            {

                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }

                synonyms[word].Add(synonym);

            }

            foreach (var key in synonyms)
            {
                Console.WriteLine($"{key.Key} - {string.Join(", ", key.Value)}");
            }
        }
    }
}
