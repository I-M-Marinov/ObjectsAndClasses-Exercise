using System;
using System.Collections.Generic;
using System.Linq;

namespace P3.Articles_2._0
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article (string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> article = new List<Article>();
            int NumberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfArticles; i++)
            {
                List<string> articlesList = Console.ReadLine().Split(", ").ToList();
                Article articles = new Article(articlesList[0], articlesList[1], articlesList[2]);
                article.Add(articles);
            }
            foreach (var item in article)
            {
                Console.WriteLine(item);
            }
        }
    }
}

