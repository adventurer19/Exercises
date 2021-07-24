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

            long height = integer();
            long[][] jagged = new long[height][];

            for (int i = 0; i < height; i++)
            {
                long[] array = new long[i + 1];
                array[0] = 1;
                array[array.Length - 1] = 1;

                for (int j = 1; j < i; j++)
                {
                    array[j] = jagged[i - 1][j] + jagged[i - 1][j - 1];
                }
                jagged[i] = array;
            }

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(String.Join(" ", jagged[i]));
            }



        }

        private static long integer()
        {
            return int.Parse(Console.ReadLine());
        }

        private static long[] ArrayRead()
        {
            long[] input = Console.ReadLine().Split(new string[] { ", ", " " }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            return input;
        }
    }
}