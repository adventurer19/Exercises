using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace Classes
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ").ToArray();
            var article = new Article(input[0], input[1], input[2]);
            //var article = new Article()
            //{
            //    Title = input[0],
            //    Content = input[1],
            //    Author = input[2]

            //};
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ").ToArray();
                if (tokens[0] == "Edit")
                {
                    article.Edit(tokens[1]);
                }
                else if (tokens[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(tokens[1]);
                }
                else if (tokens[0] == "Rename")
                {
                    article.Rename(tokens[1]);
                }
            }

            Console.WriteLine(article);

        }

    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article()
        {

        }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string input)
        {
            Content = input;
        }
        public void ChangeAuthor(string input)
        {
            Author = input;
        }
        public void Rename(string input)
        {
            Title = input;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}