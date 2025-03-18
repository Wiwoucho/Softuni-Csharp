using System.Text.RegularExpressions;

namespace MatchPhoneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"([+][3][5][9]\s[2]\s\d{3}\s\d{4}|[+][3][5][9]-[2]-\d{3}-\d{4}\b)";
            var matches = Regex.Matches(phoneNumbers, pattern);

            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
