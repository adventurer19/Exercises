using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int[,] fieldMatrix = ReadMatrix(dimensions);
            int[] bombLocation = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < bombLocation.Length; i += 2)
            {
                if (IsValidIdx(bombLocation[i], bombLocation[i + 1], fieldMatrix))
                {
                    SuperNova(fieldMatrix, bombLocation[i], bombLocation[i + 1]);
                }
            }
            int aliveCells = 0;
            int sum = 0;
            foreach (var index in fieldMatrix)
            {
                if (index > 0)
                {
                    aliveCells++;
                    sum += index;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}\nSum: {sum}");
            PrintMatrix(fieldMatrix);
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
        private static int[,] ReadMatrix(int num)
        {
            int[,] matrix = new int[num, num];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            return matrix;
        }
        private static void SuperNova(int[,] matrix, int row, int col)
        {
            int power = matrix[row, col];
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (IsValidIdx(i, j, matrix))
                    {

                        if (matrix[i, j] <= 00 || power < 0)
                        {
                            continue;

                        }
                        else
                        {
                            matrix[i, j] -= power;
                        }
                    }
                }
            }
        }
        private static bool IsValidIdx(int row, int col, int[,] matrix)
        {
            bool Valid = row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(0);
            return Valid;
        }
    }
}
