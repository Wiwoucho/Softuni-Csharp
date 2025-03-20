using System.Text.RegularExpressions;

namespace StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string starPattern = @"[STARstar]";
            string decryptPattern = @"@(?<name>[A-Za-z]+)[\w\d]*?:(\d+)[\w\d]*?!(?<type>[AD])![\w\d]*?\-\>(\d+)";
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int starMatches = Regex.Matches(text, starPattern).Count;
                string decryptedText = string.Empty;

                foreach (char letter in text)
                {
                    decryptedText += (char)(letter - starMatches);
                }

                Match matche = Regex.Match(decryptedText, decryptPattern);

                string name = matche.Groups["name"].Value;
                string type = matche.Groups["type"].Value;

                switch (type)
                {
                    case "A":
                        attackedPlanets.Add(name);
                        break;
                    case "D":
                        destroyedPlanets.Add(name);
                        break;
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planet in attackedPlanets.Order())
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planet in destroyedPlanets.Order())
            {
                Console.WriteLine($"-> {planet}");
            }

        }
    }
}
