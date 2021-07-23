using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string command = Console.ReadLine();
                string[] line = command.Split(' ');
                if (line[0] == "end") break;
                else if (line[0] == "Delete")
                {
                    input.Remove(int.Parse(line[1]));

                }
                else if (line[0] == "Insert")
                {
                    int index = int.Parse(line[2]);
                    int element = int.Parse(line[1]);
                    input.Insert(index, element);
                }

            }

            Console.WriteLine(string.Join(' ', input));

        }


    }

}