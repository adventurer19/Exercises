using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            bool xline = false;
            int count = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    xline = true;
                    break;
                }

                int[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (parts[0] == parts[1] ||
                    parts[0] < 0 ||
                    parts[0] > input.Count - 1 ||
                    parts[1] < 0 ||
                    parts[1] > input.Count - 1)
                {
                    count++;
                    string op = $"-{count}a";
                    input.Insert(input.Count / 2, op);
                    input.Insert(input.Count / 2, op);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (input[parts[0]] == input[parts[1]])
                    {
                        count++;
                        string x = input[parts[1]];
                        input.Remove(x);
                        input.Remove(x);
                        Console.WriteLine($"Congrats! You have found matching elements - {x}!");
                    }
                    else if (input[parts[0]] != input[parts[1]])
                    {
                        Console.WriteLine("Try again!");
                    }


                }

                if (input.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    break;
                }




            }
            if (xline)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', input));

            }










        }

    }
}