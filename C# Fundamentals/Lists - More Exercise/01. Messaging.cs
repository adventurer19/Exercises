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
            int capacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string command = Console.ReadLine();
                string[] line = command.Split(' ');
                if (line[0] == "end") break;
                else if (line[0] == "Add")
                {

                    input.Add(int.Parse(line[1]));
                }
                else if (line.Length == 1)
                {
                    int passenger = int.Parse(line[0]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] + passenger <= capacity)
                        {
                            input[i] += passenger;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(' ', input));

        }


    }

}