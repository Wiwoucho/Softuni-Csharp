namespace Article2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> list = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split(", ");

                string title = text[0];
                string content = text[1];
                string author = text[2];

                Article article = new Article(title, content, author);

                list.Add(article);
            }

            foreach (Article article in list)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    class Article
    {
        public string title { get; set; }
        public string content { get; set; }
        public string author { get; set; }

        public Article(string title, string content, string author)
        {

            this.title = title;
            this.content = content;
            this.author = author;
        }

        public override string ToString()
        {
            return $"{title} - {content}: {author}";
        }
    }

}
