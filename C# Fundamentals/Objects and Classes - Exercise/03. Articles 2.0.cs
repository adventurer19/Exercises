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

            List<Article> ListOfArticles = new List<Article>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                var article = new Article(input[0], input[1], input[2]);

                ListOfArticles.Add(article);

            }
            string sorting = Console.ReadLine();

            if (sorting == "title")
            {
                ListOfArticles = ListOfArticles.OrderBy(x => x.Title).ToList();


            }
            else if (sorting == "content")
            {
                ListOfArticles = ListOfArticles.OrderBy(y => y.Content).ToList();

            }
            else if (sorting == "author")
            {
                ListOfArticles = ListOfArticles.OrderBy(y => y.Author).ToList();

            }
            foreach (var Iarticle in ListOfArticles)
            {
                Console.WriteLine(Iarticle);
            }



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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}