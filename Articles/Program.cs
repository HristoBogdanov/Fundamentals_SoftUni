using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string title = arr[0];
                string content = arr[1];
                string author = arr[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }


            foreach (Article x in articles)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }

    public class Article
    { 
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title,string content,string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
