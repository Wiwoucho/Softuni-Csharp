using System.Text.RegularExpressions;

namespace race
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ").ToArray();
            string name;
            string patternName = @"[A-Za-z]+";
            string patternDiggits = @"[0-9]";

            Dictionary<string, int> winners = new ();

            while ((name = Console.ReadLine()) != "end of race")
            {
                string nameMatch = string.Concat(Regex.Matches(name, patternName).Select(n => n.Value));
                int matchDigits = Regex.Matches(name, patternDiggits).Select(d => int.Parse(d.Value)).Sum();

                    if (!winners.ContainsKey(nameMatch) && participants.Contains(nameMatch))
                    {
                        winners.Add(nameMatch, matchDigits);         
                    }
                    else if (winners.ContainsKey(nameMatch) && participants.Contains(nameMatch))
                    {
                        winners[nameMatch] += matchDigits;
                    }        
            }
            var sortedWinners = winners.OrderByDescending(r => r.Value).Take(3).ToList();

            Console.WriteLine($"1st place: {sortedWinners[0].Key}");
            Console.WriteLine($"2nd place: {sortedWinners[1].Key}");
            Console.WriteLine($"3rd place: {sortedWinners[2].Key}");
        }
    }
}
