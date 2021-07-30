using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var start = new int[2];
            var list = new List<int[]>();
            var matrix = new char[num, num];
            Matrix(matrix, start, list);
            int food = 0;
            bool escaped = false;
            escaped = true;
            while (true)
            {
               
                var line = Console.ReadLine();
                if (line == "up")
                {
                    var nextRow = start[0] - 1;
                    var nextCol = start[1];
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        matrix[start[0], start[1]] = '.';
                        if (matrix[nextRow, nextCol] == '*')
                        {
                            matrix[nextRow, nextCol] = 'S';
                            food++;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[nextRow, nextCol] = 'S';
                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            Hole(matrix, list, nextRow, nextCol,start);
                            continue;
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '.';
                        escaped = true;
                        break;
                    }
                }
                else if (line == "down")
                {
                    var nextRow = start[0] + 1;
                    var nextCol = start[1];
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        matrix[start[0], start[1]] = '.';
                        if (matrix[nextRow, nextCol] == '*')
                        {
                            matrix[nextRow, nextCol] = 'S';
                            food++;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[nextRow, nextCol] = 'S';
                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            Hole(matrix, list, nextRow, nextCol, start);
                            continue;
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '.';
                        escaped = true;
                        break;
                    }
                }
                else if (line == "right")
                {
                    var nextRow = start[0];
                    var nextCol = start[1]+1;
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        matrix[start[0], start[1]] = '.';
                        if (matrix[nextRow, nextCol] == '*')
                        {
                            matrix[nextRow, nextCol] = 'S';
                            food++;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[nextRow, nextCol] = 'S';
                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            Hole(matrix, list, nextRow, nextCol, start);
                            continue;
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '.';
                        escaped = true;
                        break;
                    }
                }
                else if (line == "left")
                {
                    var nextRow = start[0];
                    var nextCol = start[1] - 1;
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        matrix[start[0], start[1]] = '.';
                        if (matrix[nextRow, nextCol] == '*')
                        {
                            matrix[nextRow, nextCol] = 'S';
                            food++;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[nextRow, nextCol] = 'S';
                        }
                        else if (matrix[nextRow, nextCol] == 'B')
                        {
                            Hole(matrix, list, nextRow, nextCol, start);
                            continue;
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '.';
                        escaped = true;
                        break;
                    }
                }
                if (food == 10) break;

            }

            Console.WriteLine(food==10? "You won! You fed the snake.": "Game over!");
            Console.WriteLine($"Food eaten: {food}");
            Print(matrix);
        }

        private static void Hole(char[,] matrix, List<int[]> list, int nextRow, int nextCol,int[]start)
        {
            foreach (var item in list)
            {
                if (item[0] != nextRow && item[1] != nextCol)
                {
                    matrix[nextRow, nextCol] = '.';
                    matrix[item[0], item[1]] = 'S';
                    start[0] = item[0];
                    start[1] = item[1];
                }
            }
        }

        private static void Matrix(char[,] matrix, int[] start,List<int[]>list)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == 'S')
                    {
                        start[0] = i;
                        start[1] = j;
                    }

                    if (input[j] == 'B')
                    {
                     list.Add(new int[]{i,j});   
                    }
                }
            }
        }
        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }

        private static bool isValid(int row, int col, char[,] matrix)
        {
            bool isValid = row >= 0 && col >= 0 && col < matrix.GetLength(1) && row < matrix.GetLength(0);
            return isValid;
        }
    }
}
