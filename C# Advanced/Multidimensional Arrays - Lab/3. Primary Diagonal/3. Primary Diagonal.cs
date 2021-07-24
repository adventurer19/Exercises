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

            var matrix = new int[number][];
            for (int i = 0; i < number; i++)
            {
                matrix[i] = ReadArray();
            }

            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += matrix[i][i];
            }

            Console.WriteLine(sum);

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