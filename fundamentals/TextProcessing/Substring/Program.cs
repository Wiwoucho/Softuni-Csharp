namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string text = Console.ReadLine();


            while (text.Contains(substring))
            {
                int index = text.IndexOf(substring);

                string result = text.Remove(index, substring.Length);
                text = result;
            }

            Console.WriteLine(text);
        }
    }
}
