namespace charMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            int result = 0;

            int counter = Math.Max(text[0].Length, text[1].Length );

            for (int i = 0; i < counter; i++)
            {
                if (i < text[0].Length && i < text[1].Length)
                {
                    result += text[0][i] * text[1][i];
                }
                else if (i < text[0].Length)
                {
                    result += text[0][i];
                }
                else
                {
                    result += text[1][i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
