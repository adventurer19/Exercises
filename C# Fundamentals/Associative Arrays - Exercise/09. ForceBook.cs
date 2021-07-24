using System;
using System.Collections.Generic;
using System.Linq;

namespace forcebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] parts = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input.Contains("|"))
                {
                    string playerName = parts[1];
                    string sideName = parts[0];
                    bool yoyo = false;
                    foreach (var lists in dictionary)
                    {
                        if (lists.Value.Contains(playerName))
                        {
                            yoyo = true;
                            break;
                        }
                    }
                    if (yoyo)
                    {
                        continue;
                    }
                    if (!dictionary.ContainsKey(sideName))
                    {
                        dictionary.Add(sideName, new List<string>());
                    }
                    dictionary[sideName].Add(playerName);

                }
                else if (input.Contains("->"))
                {
                    string playerName = parts[0];
                    string sideName = parts[1];
                    foreach (var listTeam in dictionary)
                    {
                        if (listTeam.Value.Contains(playerName))
                        {
                            listTeam.Value.Remove(playerName);
                            break;
                        }
                    }

                    if (!dictionary.ContainsKey(sideName))
                    {
                        dictionary.Add(sideName, new List<string>());
                    }
                    dictionary[sideName].Add(playerName);
                    Console.WriteLine($"{playerName} joins the {sideName} side!");
                }

            }

            foreach (var kvp in dictionary
                .Where(x => x.Value.Count >= 1)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                foreach (var item in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}