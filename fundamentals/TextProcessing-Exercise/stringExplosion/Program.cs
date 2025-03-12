using System.Text;

namespace stringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    strength += int.Parse(text[i + 1].ToString());
                }
                else if (strength > 0)
                {
                    text.Remove(i, 1);
                    i--;
                    strength--;         
                }
            }
            Console.WriteLine(text);
        }
    }
}
