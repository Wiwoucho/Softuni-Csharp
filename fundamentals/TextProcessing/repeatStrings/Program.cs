namespace repeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            foreach (string s in text)
            {

                Console.Write(string.Concat(Enumerable.Repeat(s, s.Length)));
            }

        }
    }
}
