using System;
using System.Collections.Generic;
using System.Linq;
namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initial = Console.ReadLine().Split("!").ToList();
            while (true)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(" ");
                if (line == "Go Shopping!") break;
                if (parts[0] == "Urgent")
                {
                    if (!initial.Contains(parts[1]))
                    {
                        initial.Insert(0, parts[1]);
                    }
                }
                else if (parts[0] == "Unnecessary")
                {
                    if (initial.Contains(parts[1]))
                    {
                        initial.Remove(parts[1]);
                    }
                }
                else if (parts[0] == "Correct")
                {
                    if (initial.Contains(parts[1]))
                    {
                        int index = initial.IndexOf(parts[1]);
                        initial.Insert(index, parts[2]);
                        initial.Remove(parts[1]);
                    }
                }
                else if (parts[0] == "Rearrange")
                {
                    if (initial.Contains(parts[1]))
                    {
                        initial.Remove(parts[1]);
                        initial.Add(parts[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", initial));


        }


    }
}