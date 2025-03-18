using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var matches = Regex.Matches(names, pattern);
            Console.WriteLine(string.Join(" ", matches));

        }
    }
}
