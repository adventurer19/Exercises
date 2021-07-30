using System;
using System.Collections.Generic;
using System.Linq;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var start = new int[2];
            var matrix = new char[num, num];
            var blackHole = new List<int[]>();
            int money = 0;
            Matrix(matrix, start);
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "right")
                {
                    var nextRow = start[0];
                    var nextCol = start[1] + 1;
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        if (char.IsDigit(matrix[nextRow, nextCol]))
                        {
                            matrix[start[0], start[1]] = '-';
                            money += matrix[nextRow, nextCol] - '0';
                            matrix[nextRow, nextCol] = 'S';

                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[start[0], start[1]] = '-';
                            EnterInHole(matrix,nextRow,nextCol,blackHole,start); 
                            continue;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[start[0], start[1]] = '-';
                            matrix[nextRow, nextCol] = 'S';
                        }
                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '-';
                        break;
                    }

                    
                }
                else if (line == "up")
                {
                    var nextRow = start[0] - 1;
                    var nextCol = start[1];
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        if (char.IsDigit(matrix[nextRow, nextCol]))
                        {
                            matrix[start[0], start[1]] = '-';
                            money += matrix[nextRow, nextCol] - '0';
                            matrix[nextRow, nextCol] = 'S';

                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[start[0], start[1]] = '-';
                            EnterInHole(matrix, nextRow, nextCol, blackHole, start);
                            continue;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[start[0], start[1]] = '-';
                            matrix[nextRow, nextCol] = 'S';
                        }
                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '-';
                        break;
                    }


                }
                else if (line == "down")
                {
                    var nextRow = start[0] + 1;
                    var nextCol = start[1];
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        if (char.IsDigit(matrix[nextRow, nextCol]))
                        {
                            matrix[start[0], start[1]] = '-';
                            money += matrix[nextRow, nextCol] - '0';
                            matrix[nextRow, nextCol] = 'S';

                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[start[0], start[1]] = '-';
                            EnterInHole(matrix, nextRow, nextCol, blackHole, start);
                            continue;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[start[0], start[1]] = '-';
                            matrix[nextRow, nextCol] = 'S';
                        }
                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '-';
                        break;
                    }


                }
                else if (line == "left")
                {
                    var nextRow = start[0];
                    var nextCol = start[1] - 1;
                    if (isValid(nextRow, nextCol, matrix))
                    {
                        if (char.IsDigit(matrix[nextRow, nextCol]))
                        {
                            matrix[start[0], start[1]] = '-';
                            money += matrix[nextRow, nextCol] - '0';
                            matrix[nextRow, nextCol] = 'S';

                        }
                        else if (matrix[nextRow, nextCol] == 'O')
                        {
                            matrix[start[0], start[1]] = '-';
                            EnterInHole(matrix, nextRow, nextCol, blackHole, start);
                            continue;
                        }
                        else if (matrix[nextRow, nextCol] == '-')
                        {
                            matrix[start[0], start[1]] = '-';
                            matrix[nextRow, nextCol] = 'S';
                        }
                        start[0] = nextRow;
                        start[1] = nextCol;
                    }
                    else
                    {
                        matrix[start[0], start[1]] = '-';
                        break;
                    }


                }

                if (money >= 50)
                {
                    break;
                }

            }
            Output(money, matrix);
        }

        private static void Output(int money, char[,] matrix)
        {
            if (money < 50)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");
            Print(matrix);
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

        private static void EnterInHole(char[,] matrix, int row,int col,List<int[]> blackHole,int[]start)
        {
            var arr = new int[] {row, col};
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]=='O')
                    {
                        var location = new int[] {i, j};
                        blackHole.Add(location);
                    }
                }
            }

            foreach (var item in blackHole)
            {
                if (item[0]==arr[0] && item[1]==arr[1])
                {
                    continue;
                }
                else
                {
                    matrix[row, col] = '-';
                    matrix[item[0], item[1]] = 'S';
                    start[0] = item[0];
                    start[1] = item[1];
                }
            }

        }

        private static bool isValid(int nextRow, int nextCol, char[,] matrix)
        {
            bool result = nextRow >= 0 && nextCol >= 0 && nextRow < matrix.GetLength(0) &&
                          nextCol < matrix.GetLength(1);
            return result;
        }

        private static void Matrix(char[,] matrix, int[] start)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                    if (matrix[i, j] == 'S')
                    {
                        start[0] = i;
                        start[1] = j;
                    }
                }
            }
        }
    }
}
