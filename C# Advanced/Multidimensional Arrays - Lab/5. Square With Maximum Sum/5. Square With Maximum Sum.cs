using System;
using System.ComponentModel;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[rowsCols[0], rowsCols[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[]input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = input[j];
                }
            }

            int min = int.MinValue;
            string result = String.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i+1>= matrix.GetLength(0) || j+1>=matrix.GetLength(1))
                    {
                        continue;
                    }

                    int sum = 0;
                    sum += matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > min)
                    {
                        min = sum; 
                        result = $"{matrix[i, j]} {matrix[i, j + 1]}\n{matrix[i + 1, j]} {matrix[i + 1, j + 1]}\n{min}";
                    }
                }
            }

            Console.WriteLine(result);
        }

        private static int validRowsOrCols(int aint)
        {
            int rows = 0;
            if (aint % 2 != 0)
            {
                rows = aint - 1;
            }
            else
            {
                rows = aint;
            }

            return rows;
        }
    }
}
