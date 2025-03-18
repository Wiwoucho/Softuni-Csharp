using System.Text.RegularExpressions;

namespace MatchesDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dates = Console.ReadLine();
            var pattern = @"\b(?<day>\d{2})(?<sep>[-.\/])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b";
            var matches = Regex.Matches(dates, pattern);

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
