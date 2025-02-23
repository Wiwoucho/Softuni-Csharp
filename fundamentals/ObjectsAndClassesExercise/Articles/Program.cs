using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Articles
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split(", ");

            string title = text[0];
            string content = text[1];
            string author = text[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(":");
                string moderator = command[1];

                switch (command[0])
                {
                    case "Edit":
                        article = Edit(moderator.Trim(), article);
                        break;

                    case "ChangeAuthor":
                        article = ChangeAuthor(moderator.Trim(), article);
                        break;

                    case "Rename":
                        article = Rename(moderator.Trim(), article);
                        break;


                }

            }

            Console.WriteLine(article.ToString());
        }

        static Article Edit(string content, Article article)
        {
            article.content = content;

            return article;
        }

        static Article ChangeAuthor(string newAuthor, Article article)
        {

            article.author = newAuthor;
            return article;
        }

        static Article Rename(string newTitle, Article article)
        {
            article.title = newTitle;

            return article;
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
