namespace AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberForRandomnesses = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberForRandomnesses; i++)
            {
                Console.WriteLine(FakeMessage(phrases, events, authors, cities));

            }


        }

        static string FakeMessage(string[] phrases, string[] events, string[] authors, string[] cities)
        {
            Random rnd = new Random();
            string randomPhrase = phrases[rnd.Next(phrases.Length)];
            string randomEvent = events[rnd.Next(events.Length)];
            string randomAuthor = authors[rnd.Next(authors.Length)];
            string randomCity = cities[rnd.Next(cities.Length)];

            return $"{randomPhrase} {randomEvent} {randomAuthor} - {randomCity}";
        }
    }
}
