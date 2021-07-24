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
            var number = int.Parse(Console.ReadLine());
            string index = String.Empty;
            var matrix = new char[number][];
            bool found = false;
            for (int i = 0; i < number; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            char searched = char.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (matrix[i].Contains(searched))
                {
                    found = true;
                    int indexOfRow = new string(matrix[i]).IndexOf(searched);
                    index = $"({i}, {indexOfRow})";
                    break;
                }
            }
            string resultNegative = $"{searched} does not occur in the matrix";
            Console.WriteLine(found ? index : resultNegative);

        }

        private static int[] ReadArray()
        {
            int[] input = Console.ReadLine().Split(new string[] { ", ", " " }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            return input;
        }
    }
}