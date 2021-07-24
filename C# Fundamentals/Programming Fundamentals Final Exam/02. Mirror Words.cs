using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regex = new Regex(@"#+(?<one>[A-z]{3,}#{2}[A-z]{3,})#+|@+(?<two>[A-z]{3,}@{2}[A-z]{3,})@+");

            //var regex = new Regex(@"(\@|\#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1");
            var matches = regex.Matches(input);
            List<string> pairs = new List<string>();
            foreach (Match index in matches)
            {
                string clean = String.Empty;
                ;
                if (index.ToString().Contains("#"))
                {
                    clean = index.ToString().Replace("#", String.Empty);
                }
                else if (index.ToString().Contains("@"))
                {
                    clean = index.ToString().Replace("@", String.Empty);

                }
                pairs.Add(clean);

            }
            List<string> validwords = new List<string>();
            foreach (var idx in pairs)
            {
                if (ValidWord(idx))
                {
                    validwords.Add(idx);
                }
            }
            List<string> final = new List<string>();
            if (pairs.Count <= 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{pairs.Count} word pairs found!");

            }
            if (validwords.Count <= 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                foreach (var idx in validwords)
                {
                    var curritem = idx.Substring(0, (idx.Length / 2));
                    var curritem1 = idx.Substring(idx.Length / 2, (idx.Length - ((idx.Length / 2))));
                    string final1 = $"{curritem} <=> {curritem1}";
                    final.Add(final1);
                }
                Console.WriteLine($"{string.Join(", ", final)}");
            }

        }

        private static bool ValidWord(string result)
        {
            int boundry = result.Length / 2;
            StringBuilder wordOne = new StringBuilder();
            StringBuilder wordTwo = new StringBuilder();
            for (int i = 0; i < boundry; i++)
            {
                wordOne.Append(result[i]);
            }
            for (int i = result.Length - 1; i >= boundry; i--)
            {
                wordTwo.Append(result[i]);
            }

            bool final = wordTwo.ToString() == wordOne.ToString();
            return final;

        }
    }


}