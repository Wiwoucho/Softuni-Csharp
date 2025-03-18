namespace LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> lowerCaseDict = new Dictionary<char, int>();
            Dictionary<char, int> upperCaseDict
                = new Dictionary<char, int>();

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                lowerCaseDict[letter] = letter - 'a' + 1;
            }

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                upperCaseDict[letter] = letter - 'A' + 1;
            }

            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;

            foreach (string s in text)
            {
                    char firstLetter = s[0];
                    char lastLetter = s[s.Length - 1];
                    decimal number = decimal.Parse(s.Substring(1, s.Length - 2));

                    if (char.IsUpper(firstLetter))
                    {
                        result += number / upperCaseDict[firstLetter];
                    }
                    else if (char.IsLower(firstLetter))
                    {
                        result += number * lowerCaseDict[firstLetter];
                    }

                    if (char.IsUpper(lastLetter))
                    {
                        result -= upperCaseDict[lastLetter];
                    }
                    else if (char.IsLower(lastLetter))
                    {
                        result += lowerCaseDict[lastLetter];
                    }
            }
            Console.WriteLine($"{result:F2}");
        }
        
    }
}
