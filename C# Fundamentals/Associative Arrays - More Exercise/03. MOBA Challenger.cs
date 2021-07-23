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
            var unique = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end") break;
                if (input.Contains("->"))
                {
                    string[] parts = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player = parts[0];
                    string position = parts[1];
                    int skill = int.Parse(parts[2]);
                    if (!unique.ContainsKey(player))
                    {
                        unique.Add(player, new Dictionary<string, int>());
                        unique[player].Add(position, skill);
                    }
                    else
                    {
                        if (!unique[player].ContainsKey(position))
                        {
                            unique[player].Add(position, skill);
                            continue;
                        }
                        if (unique[player][position] < skill)
                        {
                            unique[player][position] = skill;
                        }
                    }

                }

                else if (input.Contains("vs"))
                {
                    var rolePlayer = FillTheBook(unique);
                    string[] parts = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string player = parts[0];
                    string enemy = parts[1];
                    int playerPoints = 0;
                    int enemyPoints = 0;
                    bool BREAK = false;
                    if (unique.ContainsKey(player) && unique.ContainsKey(enemy))
                    {
                        foreach (var idx in unique)
                        {
                            foreach (var kvp in idx.Value)
                            {
                                if (rolePlayer.ContainsKey(kvp.Key))
                                {
                                    if (rolePlayer[kvp.Key].Contains(player) && rolePlayer[kvp.Key].Contains(enemy))
                                    {
                                        playerPoints = unique[player][kvp.Key];
                                        enemyPoints = unique[enemy][kvp.Key];
                                        BREAK = true;
                                        break;
                                    }
                                }
                            }
                            if (BREAK) break;
                        }

                        if (playerPoints > enemyPoints)
                        {
                            unique.Remove(enemy);
                        }
                        else if (playerPoints < enemyPoints)
                        {
                            unique.Remove(player);
                        }


                    }
                }
            }

            var sorted = new Dictionary<string, int>();
            foreach (var idx in unique)
            {
                foreach (var kvp in idx.Value)
                {
                    if (!sorted.ContainsKey(idx.Key))
                    {
                        sorted.Add(idx.Key, kvp.Value);
                    }
                    else
                    {
                        sorted[idx.Key] += kvp.Value;
                    }
                }
            }

            foreach (var kvp in sorted.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");
                foreach (var idx in unique)
                {
                    // Console.WriteLine(idx.Key);
                    foreach (var index in idx.Value
                        .OrderByDescending(x => x.Value)
                        .ThenBy(x => x.Key))
                    {
                        if (idx.Key == kvp.Key)
                        {
                            Console.WriteLine($" - {index.Key} <::> {index.Value}");
                        }
                    }
                }
            }


        }


        private static Dictionary<string, List<string>> FillTheBook(Dictionary<string, Dictionary<string, int>> unique)
        {
            var bookRoleKeyPlayerValue = new Dictionary<string, List<string>>();
            foreach (var idx in unique)
            {
                foreach (var index in idx.Value)
                {
                    if (!bookRoleKeyPlayerValue.ContainsKey(index.Key))
                    {
                        bookRoleKeyPlayerValue.Add(index.Key, new List<string>());
                        bookRoleKeyPlayerValue[index.Key].Add(idx.Key);

                    }
                    else if (!bookRoleKeyPlayerValue[index.Key].Contains(idx.Key))
                    {
                        bookRoleKeyPlayerValue[index.Key].Add(idx.Key);
                    }
                }
            }
            return bookRoleKeyPlayerValue;
        }


    }
}