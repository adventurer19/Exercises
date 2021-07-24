using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Advanced
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

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);


        }

        private static int[] ReadArray()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            return input;
        }
    }
}