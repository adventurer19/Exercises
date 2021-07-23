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
            var contestBook = new Dictionary<string, string>();
            var dictionary = new Dictionary<string, Dictionary<string, int>>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input.Split(':').ToArray();
                if (!contestBook.ContainsKey(tokens[0]))
                {
                    contestBook.Add(tokens[0], tokens[1]);
                }
            }
            string line = String.Empty;
            while ((line = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = line.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contestBook.ContainsKey(contest))
                {
                    if (contestBook[contest].Equals(password))
                    {
                        if (!dictionary.ContainsKey(username)) // Checking that user is not existing
                        {
                            dictionary.Add(username, new Dictionary<string, int>());
                            dictionary[username].Add(contest, points);

                        }
                        else if (dictionary.ContainsKey(username)) // here user is existing
                        {
                            if (dictionary[username].ContainsKey(contest)) // here we already have the contest
                            {
                                if (dictionary[username][contest] > points)
                                {
                                    continue; //herer we have the contest but all values are higher than the current one so we continue
                                }
                            }
                            else if (!dictionary[username].ContainsKey(contest))// here we dont have the contest
                            {
                                dictionary[username].Add(contest, points);// creating  a new contest + empty list
                            }
                            dictionary[username][contest] = points;//here we add value to the current list of the contest of the player


                        }


                    }
                }
            }

            var scoreBook = new Dictionary<string, int>();
            foreach (var idx in dictionary)
            {
                scoreBook[idx.Key] = idx.Value.Values.Sum();
            }

            int maxPoint = scoreBook.Values.Max();
            foreach (var pair in scoreBook)
            {
                if (pair.Value == maxPoint)
                {
                    Console.WriteLine($"Best candidate is {pair.Key} with total {pair.Value} points.");

                }
            }
            Console.WriteLine($"Ranking: ");
            foreach (var kvp in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var index in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {index.Key} -> {index.Value}");

                }
            }

        }
    }
}