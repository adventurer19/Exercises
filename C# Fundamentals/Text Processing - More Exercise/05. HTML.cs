using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace text_proc
{
    class Program
    {
        static void Main(string[] args)
        {

            string title = Console.ReadLine();
            string contentArticle = Console.ReadLine();
            List<string> list = new List<string>();
            while (true)
            {
                string comments = Console.ReadLine();
                if (comments == "end of comments") break;
                list.Add(comments);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"     {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine($"<article>");
            Console.WriteLine($"     {contentArticle}");
            Console.WriteLine($"</article>");
            foreach (var idx in list)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"     {idx}");
                Console.WriteLine($"</div>");
            }
        }
    }
}