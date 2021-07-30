using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var listIdx = Attacks();
            var count = listIdx.Count;
            var matrix = Matrix(size);
            var score = new int[2];
            bool won = false;
            CheckScore(matrix, score);
            var allShips = score.Sum();
            foreach (var turn in listIdx)
            {
                count--;
                var row = turn[0];
                var col = turn[1];
                if (Valid(row, col, matrix))
                {
                    if (matrix[row,col]=='#')
                    {
                        matrix[row, col] = 'X';
                        if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
                        {
                            matrix[row + 1, col-1] = 'X';
                        }

                        if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(0))
                        {
                            matrix[row + 1, col+1] = 'X';
                        }

                        if (row - 1 >= 0 && col - 1 >= 0)
                        {
                            matrix[row - 1, col-1] = 'X';
                        }

                        if (row - 1 >= 0 && col + 1 < matrix.GetLength(0))
                        {
                            matrix[row - 1, col+1] = 'X';
                        }

                        if (row + 1 < matrix.GetLength(0))
                        {
                            matrix[row + 1, col] = 'X';
                        }
                        if (col + 1 < matrix.GetLength(0))
                        {
                            matrix[row, col + 1] = 'X';
                        }
                        if (row - 1 >= 0)
                        {
                            matrix[row - 1, col] = 'X';
                        }
                        if (col - 1 >= 0)
                        {
                            matrix[row, col - 1] = 'X';
                        }
                    }
                    else if (matrix[row, col] == '>')
                    {
                        matrix[row, col] = 'X';
                    }
                    else if (matrix[row, col] == '<')
                    {
                        matrix[row, col] = 'X';
                    }
                    CheckScore(matrix,score);
                }
                if (score.Any(x => x <= 0))
                {
                    won = true;
                    break;
                }
              
                
            }
            var ships =allShips - score.Sum();
            if(count==0 &&!won )
            {
                Console.WriteLine($"It's a draw! Player One has {score[0]} ships left. Player Two has {score[1]} ships left.");
            }
            else if (score[0]>score[1])
            {
                Console.WriteLine($"Player One has won the game! {ships} ships have been sunk in the battle.");
            }
            else if (score[0] < score[1])
            {
                Console.WriteLine($"Player Two has won the game! {ships} ships have been sunk in the battle.");
            }
          //  Print(matrix);
        }

        private static bool Valid(int row, int col, char[,] matrix)
        {
            bool IsValid = row >= 0 && row < matrix.GetLength(0) &&
                           col >= 0 && col < matrix.GetLength(1);
            return IsValid;
        }

        private static void CheckScore(char[,] matrix, int[] score)
        {
            score[0] = 0;
            score[1] = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '<')
                    {
                        score[0]++;
                    }
                    else if (matrix[i, j] == '>')
                    {
                        score[1]++;
                    }
                }
            }
        }

        private static List<int[]> Attacks()
        {
            var listIdx = new List<int[]>();
            var line = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in line)
            {
                var data = item.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                listIdx.Add(data);
            }

            return listIdx;
        }

        private static char[,] Matrix(int size)
        {
            var matrix = new char[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }

        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
