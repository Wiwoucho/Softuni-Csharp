namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                Console.WriteLine($"{text} = {string.Join("", text.Reverse())}");
                text = Console.ReadLine();

            }
        }
    }
}
