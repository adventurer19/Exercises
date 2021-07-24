using System;
using System.Linq;
using System.Collections.Generic;
class TreasureHunt
{
    static void Main(string[] args)
    {
        List<string> loot = Console.ReadLine().Split("|").ToList();
        string command = Console.ReadLine();

        while (command != "Yohoho!")
        {
            string[] splitted = command.Split(" ");
            string doing = splitted[0];
            if (doing == "Loot")
            {
                for (int i = 1; i < splitted.Length; i++)
                {
                    if (!loot.Contains(splitted[i]))
                    {
                        loot.Insert(0, splitted[i]);
                    }
                }
            }
            else if (doing == "Drop")
            {
                int index = int.Parse(splitted[1]);
                if (index >= 0 && index <= loot.Count - 1)
                {
                    string item = loot[index];
                    loot.RemoveAt(index);
                    loot.Add(item);
                }
            }
            else if (doing == "Steal")
            {
                List<string> stolenItems = new List<string>();
                int count = int.Parse(splitted[1]);
                int validCount = Math.Min(count, loot.Count);
                for (int i = loot.Count - validCount; i < loot.Count; i++)
                {
                    stolenItems.Add(loot[i]);
                }
                Console.WriteLine(string.Join(", ", stolenItems));
                loot.RemoveRange(loot.Count - validCount, validCount);
            }

            command = Console.ReadLine();
        }
        if (loot.Count == 0)
        {
            Console.WriteLine($"Failed treasure hunt.");
        }
        else
        {
            double lengthSum = 0;

            for (int i = 0; i < loot.Count; i++)
            {
                lengthSum += loot[i].Length;
            }

            double averageGain = lengthSum / loot.Count;
            Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
        }

    }
}