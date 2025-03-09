namespace digitsLettersOthers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<char> letters = new();
            List<int> digits = new();
            List<char> symbols = new();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (char.IsLetter(currentChar))
                {
                    letters.Add(currentChar);
                }
                else if (char.IsDigit(currentChar))
                {
                    digits.Add(currentChar - '0');
                }
                else
                {
                    symbols.Add(currentChar);
                }
            }

            Console.WriteLine($"{string.Join("", digits)}\n{string.Join("", letters)}\n{string.Join("", symbols)}");
        }
    }
}
