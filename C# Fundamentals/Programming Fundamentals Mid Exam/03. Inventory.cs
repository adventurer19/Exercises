using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> input = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(" - ").ToArray();
                if (line == "Craft!") break;
                if (parts[0] == "Collect")
                {
                    if (!input.Contains(parts[1]))
                    {
                        input.Add(parts[1]);
                    }
                }
                else if (parts[0] == "Drop")
                {
                    if (input.Contains(parts[1]))
                    {
                        input.Remove(parts[1]);
                    }
                }
                else if (parts[0] == "Renew")
                {
                    if (input.Contains(parts[1]))
                    {
                        input.Remove(parts[1]);
                        input.Add(parts[1]);
                    }
                }
                else if (parts[0] == "Combine Items")
                {
                    string[] command = parts[1].Split(":").ToArray();
                    if (input.Contains(command[0]))
                    {
                        int index = input.IndexOf(command[0]) + 1;
                        input.Insert(index, command[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }


    }
}