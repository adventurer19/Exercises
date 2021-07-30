using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new int[nums[0],nums[1]];  
            string line = Console.ReadLine();
            var list = new List<int[]>();
            while (line != "Bloom Bloom Plow")
            {
                int[] moves = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var row = moves[0];
                var col = moves[1];
                if (isValid(row, col, matrix))
                {
                    
                    list.Add(new int[]{row,col});
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                line = Console.ReadLine();
            }

            foreach (var info in list)
            {
                for (int i =0 ;i < matrix.GetLength(0); i++)
                {
                    if (matrix[info[0], i] != 0)
                    {
                        matrix[info[0], i]++;
                        matrix[i, info[1]]++;
                    }
                    else
                    {
                        matrix[info[0], i] = 1;
                        matrix[i, info[1]] = 1; 
                    }
                }
            }

            Print(matrix);

        }

        private static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool isValid(int row, int col, int[,] matrix)
        {
            bool isValid = row >= 0 && col >= 0 && col < matrix.GetLength(1) && row < matrix.GetLength(0);
            return isValid;
        }
    }
}
