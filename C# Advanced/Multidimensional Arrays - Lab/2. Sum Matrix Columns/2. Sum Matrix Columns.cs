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
            var input = ReadArray();
            int sum = 0;
            int[,] matrix = new int[input[0], input[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var cols = ReadArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = cols[j];
                    sum += cols[j];
                }

            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int suminside = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    suminside += matrix[j, i];
                }

                Console.WriteLine(suminside);
            }

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