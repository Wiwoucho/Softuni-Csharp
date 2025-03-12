using System.Text;

namespace ceasarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < text.Length; i++)
            {
                text[i] = (char)(text[i] + 3);
            }
            Console.WriteLine(text);
        }
    }
}
