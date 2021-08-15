using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.classes
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string,int>();
            var line = string.Empty;
            while ((line = Console.ReadLine()) != "Log out")
            {
                var cmd = line.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var username = cmd[1];
                switch (cmd[0])
                {
                    case "New follower":
                        if (!dictionary.ContainsKey(username))
                        {
                            dictionary.Add(username, 0);
                        }
                        break;
                    case "Like":
                        var count = int.Parse(cmd[2]);
                        if (!dictionary.ContainsKey(username))
                        {
                            dictionary.Add(username, count);
                        }
                        else
                        {
                            dictionary[username] += count;
                        }
                        break;
                    case "Comment":
                        if (!dictionary.ContainsKey(username))
                        {
                            dictionary.Add(username, 1);
                        }
                        else 
                        {
                            dictionary[username]++;
                        }
                        break;
                    case "Blocked":
                        if (dictionary.ContainsKey(username))
                        {
                            dictionary.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        break;

                }
            }

            PrintResult(dictionary);
        }


        private static void PrintResult(Dictionary<string, int> dictionary)
        {
            Console.WriteLine($"{dictionary.Count} followers");
            foreach (var item in dictionary
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
