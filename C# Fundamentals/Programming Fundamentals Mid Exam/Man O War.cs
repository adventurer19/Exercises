using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = new List<int>();
            List<int> secondLine = new List<int>();
            string line = String.Empty;
            for (int i = 1; i <= 2; i++)
            {
                List<int> input = Console.ReadLine()
                    .Split('>', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();
                if (i == 1) firstLine.InsertRange(0, input);

                else if (i == 2) secondLine.InsertRange(0, input);
                input.Clear();
            }
            int capacity = int.Parse(Console.ReadLine());
            bool lost = false;
            bool win = false;
            while ((line = Console.ReadLine()) != "Retire")
            {
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (parts[0] == "Fire")
                {
                    int idx = int.Parse(parts[1]);
                    int dmg = int.Parse(parts[2]);
                    if (idx >= 0 && idx < secondLine.Count)
                    {
                        secondLine[idx] -= dmg;
                        if (secondLine.Any(x => x <= 0))
                        {
                            win = true;
                            break;
                        }

                    }

                }
                else if (parts[0] == "Defend")
                {
                    int idx = int.Parse(parts[1]);
                    int end = int.Parse(parts[2]);
                    int dmg = int.Parse(parts[3]);
                    bool index = false;
                    bool endIndex = false;
                    if (idx >= 0 && idx < firstLine.Count) index = true;
                    if (end >= 0 && end < firstLine.Count) endIndex = true;
                    if (index && endIndex)
                    {
                        for (int i = idx; i <= end; i++)
                        {
                            firstLine[i] -= dmg;
                        }

                        if (firstLine.Any(x => x <= 0))
                        {
                            lost = true;
                            break;
                        }
                    }



                }
                else if (parts[0] == "Repair")
                {
                    int idx = int.Parse(parts[1]);
                    int heal = int.Parse(parts[2]);
                    if (idx >= 0 && idx < firstLine.Count)
                    {
                        if (firstLine[idx] + heal <= capacity)
                        {
                            firstLine[idx] += heal;
                        }
                        else if (firstLine[idx] + heal > capacity)
                        {
                            firstLine[idx] += capacity - firstLine[idx];
                        }
                    }

                }
                else if (parts[0] == "Status")
                {
                    int countRepair = 0;
                    double lower = 1.0 * capacity / 100 * 20;
                    for (int i = 0; i < firstLine.Count; i++)
                    {
                        if (firstLine[i] < lower)
                        {
                            countRepair++;
                        }
                    }

                    Console.WriteLine($"{countRepair} sections need repair.");
                }

            }

            if (lost) { Console.WriteLine("You lost! The pirate ship has sunken."); }

            if (win) { Console.WriteLine("You won! The enemy ship has sunken."); }

            if (!lost && !win)
            {
                int first = firstLine.Sum();
                int second = secondLine.Sum();
                Console.WriteLine($"Pirate ship status: {first}");
                Console.WriteLine($"Warship status: {second}");

            }

        }

    }
}