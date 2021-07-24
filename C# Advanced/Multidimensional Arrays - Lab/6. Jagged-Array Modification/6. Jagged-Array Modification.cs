using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Advance
{

    class Program
    {
        static void Main(string[] args)
        {

            int x = integer();
            int[][] jagged = new int[x][];
            for (int i = 0; i < x; i++)
            {
                jagged[i] = ArrayRead();

            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] parts = input.Split(' ').ToArray();
                string line = parts[0];
                int a = int.Parse(parts[1]);
                int b = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);
                bool first = (a >= 0 && a < x);
                bool second = (b >= 0 && b < x);
                if (line == "Add")
                {

                    if (first && second)
                    {
                        jagged[a][b] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (line == "Subtract")
                {
                    if (first && second)
                    {
                        jagged[a][b] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var idx in jagged)
            {
                Console.WriteLine(string.Join(' ', idx));
            }
        }

        private static int integer()
        {
            return int.Parse(Console.ReadLine());
        }

        private static int[] ArrayRead()
        {
            int[] input = Console.ReadLine().Split(new string[] { ", ", " " }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            return input;
        }
    }
}