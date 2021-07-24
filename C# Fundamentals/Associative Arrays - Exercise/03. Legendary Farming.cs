using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var weapons = new Dictionary<string, int> { { "shards", 0 }, { "fragments", 0 }, { "motes", 0 } };
            var junk = new SortedDictionary<string, int>();

            //Shadowmourne - requires 250 Shards;
            //Valanyr - requires 250 Fragments;
            //Dragonwrath - requires 250 Motes;
            string winner = String.Empty;
            bool Exit = false;
            while (!Exit)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    int amount = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (weapons.ContainsKey(material))
                    {
                        weapons[material] += amount;
                        if (weapons[material] >= 250)
                        {
                            winner = material;
                            weapons[material] -= 250;
                            Exit = true;
                            break;
                        }

                    }
                    else if (junk.ContainsKey(material))
                    {
                        junk[material] += amount;
                    }
                    else
                    {
                        junk.Add(material, amount);
                    }
                }
            }

            var sortedMain = weapons
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            if (winner == "shards")
            {
                winner = "Shadowmourne";
            }
            else if (winner == "fragments")
            {
                winner = "Valanyr";
            }
            else if (winner == "motes")
            {
                winner = "Dragonwrath";
            }
            Console.WriteLine($"{winner} obtained!");
            foreach (var idx in sortedMain)
            {
                Console.WriteLine($"{idx.Key}: {idx.Value}");
            }

            foreach (var idx in junk)
            {
                Console.WriteLine($"{idx.Key}: {idx.Value}");
            }
        }
    }
}
