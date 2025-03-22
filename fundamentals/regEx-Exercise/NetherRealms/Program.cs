using System.Globalization;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (int health, double damage)> deamons = new();

            string[] input = Console.ReadLine().Split(new[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);

            string damagePattern = @"[-+]?\d*.?\d+";


            foreach(string deamon in input)
            {
                int hp = deamon.Where(h => !char.IsDigit(h) && "+-*/.".IndexOf(h) == -1).Sum(c => c);

                MatchCollection matches = Regex.Matches(deamon, damagePattern);
                double damage = matches.Cast<Match>().Sum(m => double.Parse(m.Value));

                foreach (char c in deamon)
                {
                    if (c == '*') damage *= 2;
                    else if (c == '/') damage /= 2;
                }

                deamons.Add(deamon, (hp, damage));
            }

            foreach (var demon in deamons.OrderBy(d => d.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.health} health, {demon.Value.damage:F2} damage");
            }
        }
    }
}
