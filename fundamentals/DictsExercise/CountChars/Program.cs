namespace CountChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().Replace(" ","");

            Dictionary<char, int> charCount = new ();

            foreach (char c in text)
            {

                if (!charCount.ContainsKey(c))
                {
                    charCount.Add(c, 0);
                }

                charCount[c]++;
            }

            foreach ((char c, int count)in charCount)
            {
                Console.WriteLine($"{c} -> {count}");
            }
        }
    }
}
