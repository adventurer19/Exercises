using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            var start = new int[2];
            var matrix = new char[x, x];
            int flowers = 0;
            Matrix(matrix, start);
            bool lost = false;
            var line = Console.ReadLine();
            while (line != "End")
            {
                if (line == "right")
                {
                    var nextRow = start[0];
                    var nextCol = start[1] + 1;
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        matrix[start[0], start[1]] = '.';
                        if (matrix[nextRow, nextCol] == 'f')
                        {
                            matrix[nextRow, nextCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[nextRow, nextCol] == '.')
                        {
                            matrix[nextRow, nextCol] = 'B';
                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            if (!isValid(nextRow, nextCol + 1, matrix))
                            {
                                lost = true;
                                break;
                            }
                            else
                            {
                                if (matrix[nextRow, nextCol + 1] == 'f')
                                {
                                    flowers++;
                                }

                                matrix[nextRow, nextCol] = '.';
                                matrix[nextRow, nextCol + 1] = 'B';
                                start[0] = nextRow;
                                start[1] = nextCol;
                                continue;
                            }
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        lost = true;
                        matrix[start[0], start[1]] = '.';
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
                        if (matrix[nextRow, nextCol] == 'f')
                        {
                            matrix[nextRow, nextCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[nextRow, nextCol] == '.')
                        {
                            matrix[nextRow, nextCol] = 'B';
                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            if (!isValid(nextRow, nextCol - 1, matrix))
                            {
                                lost = true;
                                break;
                            }
                            else
                            {
                                if (matrix[nextRow, nextCol - 1] == 'f')
                                {
                                    flowers++;
                                }

                                matrix[nextRow, nextCol] = '.';
                                matrix[nextRow, nextCol - 1] = 'B';
                                start[0] = nextRow;
                                start[1] = nextCol;
                                continue;
                            }
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        lost = true;
                        matrix[start[0], start[1]] = '.';
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
                        if (matrix[nextRow, nextCol] == 'f')
                        {
                            matrix[nextRow, nextCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[nextRow, nextCol] == '.')
                        {
                            matrix[nextRow, nextCol] = 'B';
                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            if (!isValid(nextRow + 1, nextCol, matrix))
                            {
                                lost = true;
                                break;
                            }
                            else
                            {
                                if (matrix[nextRow + 1, nextCol] == 'f')
                                {
                                    flowers++;
                                }

                                matrix[nextRow, nextCol] = '.';
                                matrix[nextRow + 1, nextCol] = 'B';
                                start[0] = nextRow;
                                start[1] = nextCol;
                                continue;
                            }
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        lost = true;
                        matrix[start[0], start[1]] = '.';
                        break;
                    }
                }
                else if (line == "up")
                {
                    var nextRow = start[0] - 1;
                    var nextCol = start[1];
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        matrix[start[0], start[1]] = '.';
                        if (matrix[nextRow, nextCol] == 'f')
                        {
                            matrix[nextRow, nextCol] = 'B';
                            flowers++;
                        }
                        else if (matrix[nextRow, nextCol] == '.')
                        {
                            matrix[nextRow, nextCol] = 'B';
                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            if (!isValid(nextRow - 1, nextCol, matrix))
                            {
                                lost = true;
                                break;
                            }
                            else
                            {
                                if (matrix[nextRow - 1, nextCol] == 'f')
                                {
                                    flowers++;
                                }

                                matrix[nextRow, nextCol] = '.';
                                matrix[nextRow - 1, nextCol] = 'B';
                                start[0] = nextRow;
                                start[1] = nextCol;
                                continue;
                            }
                        }

                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        lost = true;
                        matrix[start[0], start[1]] = '.';
                        break;
                    }
                }

                line = Console.ReadLine();
                //Print(matrix);
            }

            if (lost) Console.WriteLine("The bee got lost!");
            Console.WriteLine(flowers < 5
                ? $"The bee couldn't pollinate the flowers, she needed {5 - flowers} flowers more"
                : $"Great job, the bee managed to pollinate {flowers} flowers!");
            Print(matrix);
        }

        private static void Matrix(char[,] matrix, int[] start)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == 'B')
                    {
                        start[0] = i;
                        start[1] = j;
                    }
                }
            }
        }

        private static bool isValid(int row, int col, char[,] matrix)
        {
            bool isValid = row >= 0 && col >= 0 && col < matrix.GetLength(1) && row < matrix.GetLength(0);
            return isValid;
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
    }
}
