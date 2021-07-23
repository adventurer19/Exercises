using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string line = Console.ReadLine();
                string[] command = line.Split(' ');
                if (line == "end") break;
                else if (command[0] == "Add") nums.Add(int.Parse(command[1]));
                else if (command[0] == "Remove") nums.Remove(int.Parse(command[1]));
                else if (command[0] == "RemoveAt") nums.RemoveAt(int.Parse(command[1]));
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    int number = int.Parse(command[1]);
                    nums.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}