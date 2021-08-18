using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Advance
{

    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            var matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = DoubleParseArray();
            }
            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    matrix[i] = matrix[i].ToList().Select(x => x * 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].ToList().Select(x => x * 2).ToArray();
                }
                else if (matrix[i].Length != matrix[i + 1].Length)
                {
                    matrix[i] = matrix[i].ToList().Select(x => x / 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].ToList().Select(x => x / 2).ToArray();
                }

            }
            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] input = line.Split(' ').ToArray();
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                bool validIndex =
                    row >= 0 && row < rows &&
                    col < matrix[row].Length &&
                    col >= 0;
                if (input[0] == "Add" && input.Length == 4 && validIndex)
                {
                    matrix[row][col] += value;
                }
                else if (input[0] == "Subtract" && input.Length == 4 && validIndex)
                {
                    matrix[row][col] -= value;
                }

                line = Console.ReadLine();
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(' ', matrix[i]));
            }
        }

        private static double[] DoubleParseArray()
        {
            return Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        }
    }

}