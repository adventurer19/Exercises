using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[,] matrix = new char[num, num];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = data[j];

                }
            }

            int removed = 0;

            while (true)
            {
                int power = 0;
                int knightRow = -1;
                int knightCol = -1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        if (matrix[i, j] == 'K')
                        {
                            int attacks = CountAttacks(i, j, matrix);
                            if (attacks > power)
                            {
                                power = attacks;
                                knightRow = i;
                                knightCol = j;
                            }
                        }
                    }
                }
                if (power > 0)
                {
                    matrix[knightRow, knightCol] = '0';
                    removed++;
                }
                else
                {
                    break;
                }

            }


            Console.WriteLine(removed);


        }

        private static List<int[]> TakeKnights(char[,] matrix, int row, int cols)
        {
            List<int[]> index = new List<int[]>();
            if (IsValidPos(row + 2, cols + 1, matrix) && matrix[row + 2, cols + 1] == 'K')
            {
                int[] current = new[] { row + 2, cols + 1 };
                index.Add(current);
            }

            if (IsValidPos(row + 2, cols - 1, matrix) && matrix[row + 2, cols - 1] == 'K')
            {
                int[] current = new[] { row + 2, cols - 1 };
                index.Add(current);
            }

            if (IsValidPos(row - 2, cols + 1, matrix) && matrix[row - 2, cols + 1] == 'K')
            {
                int[] current = new[] { row - 2, cols + 1 };
                index.Add(current);
            }
            if (IsValidPos(row - 2, cols - 1, matrix) && matrix[row - 2, cols - 1] == 'K')
            {
                int[] current = new[] { row - 2, cols - 1 };
                index.Add(current);
            }

            if (IsValidPos(row - 1, cols + 2, matrix) && (matrix[row - 1, cols + 2] == 'K'))
            {
                int[] current = new[] { row - 1, cols + 2 };
                index.Add(current);

            }
            if (IsValidPos(row + 1, cols + 2, matrix) && (matrix[row + 1, cols + 2] == 'K'))
            {
                int[] current = new[] { row + 1, cols + 2 };
                index.Add(current);
            }
            if (IsValidPos(row - 1, cols - 2, matrix) && (matrix[row - 1, cols - 2] == 'K'))
            {
                int[] current = new[] { row - 1, cols - 2 };
                index.Add(current);
            }
            if (IsValidPos(row + 1, cols - 2, matrix) && (matrix[row + 1, cols - 2] == 'K'))
            {
                int[] current = new[] { row + 1, cols - 2 };
                index.Add(current);
            }

            return index;
        }

        private static int CountAttacks(int row, int cols, char[,] matrix)
        {
            int attacks = 0;
            if (IsValidPos(row + 2, cols + 1, matrix) && matrix[row + 2, cols + 1] == 'K')
            {
                attacks++;
            }

            if (IsValidPos(row + 2, cols - 1, matrix) && matrix[row + 2, cols - 1] == 'K')
            {
                attacks++;
            }

            if (IsValidPos(row - 2, cols + 1, matrix) && matrix[row - 2, cols + 1] == 'K')
            {
                attacks++;
            }
            if (IsValidPos(row - 2, cols - 1, matrix) && matrix[row - 2, cols - 1] == 'K')
            {
                attacks++;
            }

            if (IsValidPos(row - 1, cols + 2, matrix) && (matrix[row - 1, cols + 2] == 'K'))
            {
                attacks++;

            }
            if (IsValidPos(row + 1, cols + 2, matrix) && (matrix[row + 1, cols + 2] == 'K'))
            {
                attacks++;

            }
            if (IsValidPos(row - 1, cols - 2, matrix) && (matrix[row - 1, cols - 2] == 'K'))
            {
                attacks++;

            }
            if (IsValidPos(row + 1, cols - 2, matrix) && (matrix[row + 1, cols - 2] == 'K'))
            {
                attacks++;

            }

            return attacks;
        }

        private static bool IsValidPos(int rows, int cols, char[,] matrix)
        {
            bool validIdx =
                rows >= 0
                && rows < matrix.GetLength(0)
                && cols >= 0
                && cols < matrix.GetLength(0);
            return validIdx;
        }
    }
}
