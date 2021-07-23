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
            var magicBook = new Dictionary<string, Dictionary<string, int>>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] tokens = input.Split(" -> ").ToArray();
                string userName = tokens[0];
                string contest = tokens[1];
                int points = int.Parse(tokens[2]);
                if (!magicBook.ContainsKey(contest))
                {
                    magicBook.Add(contest, new Dictionary<string, int>());
                    magicBook[contest].Add(userName, points);
                }
                else
                {
                    if (!magicBook[contest].ContainsKey(userName))
                    {
                        magicBook[contest].Add(userName, points);
                    }
                    else
                    {
                        if (magicBook[contest][userName] > points)
                        {
                            continue;
                        }
                    }
                    magicBook[contest][userName] = points;
                }
            }

            var individuals = new Dictionary<string, int>();
            foreach (var index in magicBook)
            {
                foreach (var kvp in index.Value)
                {
                    if (individuals.ContainsKey(kvp.Key))
                    {
                        individuals[kvp.Key] += kvp.Value;
                    }
                    else
                    {
                        individuals.Add(kvp.Key, kvp.Value);
                    }
                }
            }
            foreach (var index in magicBook)
            {
                int position = 0;
                Console.WriteLine($"{index.Key}: {index.Value.Count} participants");
                foreach (var idx in index.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    position++;
                    Console.WriteLine($"{position}. {idx.Key} <::> {idx.Value}");
                }
            }

            int number = 0;
            Console.WriteLine($"Individual standings:");
            foreach (var index in individuals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                number++;
                Console.WriteLine($"{number}. {index.Key} -> {index.Value}");
            }
        }
    }
}