namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            
            foreach (string word in bannedWords)
            {
                string result1 = text.Replace(word, new string('*', word.Count()));
                text = result1;
            }



            Console.WriteLine(text);
        }
    }
}
