namespace ValidUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split('\\');

            string[] filename = text[text.Length - 1].Split(".");

            Console.WriteLine($"File name: {filename[0]}");
            Console.WriteLine($"File extension: {filename[1]}");
        }
    }
}
