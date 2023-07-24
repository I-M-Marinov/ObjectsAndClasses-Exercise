using System;
using System.Collections.Generic;
using System.Linq;

namespace P2.Articles
{

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listArticles = Console.ReadLine().Split(", ").ToList();
            Article article = new Article(listArticles[0], listArticles[1], listArticles[2]);

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();

                if (command[0] == "Edit")
                {
                    article.Content = command[1];
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.Author = command[1];
                }
                else if (command[0] == "Rename")
                {
                    article.Title = command[1];
                }
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
