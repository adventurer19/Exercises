using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());
            var matrix = Matrix(dimensions, dimensions);
            var location = Location(matrix);
            var oldRow = location[0];
            var oldCol = location[1];
            var newRow = oldRow;
            var newCol = oldCol;
            bool isWin = false;
            for (int commands = 0; commands < commandsCount; commands++)
            {
                string line = Console.ReadLine();
                switch (line)
                {
                    case"down":
                        if (oldRow + 1 >= matrix.GetLength(0))
                        {
                            newRow = 0;
                            newCol = oldCol;
                        }
                        else
                        {
                            newRow = oldRow + 1;
                            newCol = oldCol;
                        }
                        if (matrix[newRow, newCol] == '-')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            RenewValues(newRow, newCol, out oldRow, out oldCol);
                        }
                        else if (matrix[newRow, newCol] == 'B')
                        {
                            matrix[oldRow, oldCol] = '-';
                            if (newRow + 1 >= matrix.GetLength(0))
                            {
                                newRow = 0;
                                if (matrix[newRow, newCol] == 'F')
                                {
                                    matrix[newRow, newCol] = 'f';
                                    isWin = true;
                                    break;
                                }
                                matrix[newRow, newCol] = 'f';
                                RenewValues(newRow, newCol, out oldRow, out oldCol);
                                continue;
                            }
                            matrix[newRow + 1, newCol] = 'f';
                            oldRow = newRow + 1;
                            oldCol = newCol;

                        }
                        else if (matrix[newRow, newCol] == 'T')
                        {
                            continue;
                        }
                        else if (matrix[newRow, newCol] == 'F')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            isWin = true;
                            break;
                        }
                        break;
                    case "up":
                        if (oldRow - 1 < 0)
                        {
                            newRow = matrix.GetLength(0) - 1;
                            newCol = oldCol;
                        }
                        else
                        {
                            newRow = oldRow - 1;
                            newCol = oldCol;
                        }

                        if (matrix[newRow, newCol] == '-')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            RenewValues(newRow, newCol, out oldRow, out oldCol);
                        }
                        else if (matrix[newRow, newCol] == 'B')
                        {
                            matrix[oldRow, oldCol] = '-';
                            if (newRow - 1 < 0)
                            {
                                newRow = matrix.GetLength(0) - 1;
                                if (matrix[newRow, newCol] == 'F')
                                {
                                    matrix[newRow, newCol] = 'f';
                                    isWin = true;
                                    break;
                                }
                                matrix[newRow, newCol] = 'f';
                                RenewValues(newRow, newCol, out oldRow, out oldCol);
                                continue;
                            }

                            matrix[newRow - 1, newCol] = 'f';
                            oldRow = newRow - 1;
                            oldCol = newCol;

                        }
                        else if (matrix[newRow, newCol] == 'T')
                        {
                            continue;
                        }
                        else if (matrix[newRow, newCol] == 'F')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            isWin = true;
                            break;
                        }
                        break;
                    case "right":
                        if (oldCol + 1 >= matrix.GetLength(1))
                        {
                            newRow = oldRow;
                            newCol = 0;
                        }
                        else
                        {
                            newRow = oldRow;
                            newCol = oldCol + 1;
                        }

                        if (matrix[newRow, newCol] == '-')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            RenewValues(newRow, newCol, out oldRow, out oldCol);
                        }
                        else if (matrix[newRow, newCol] == 'B')
                        {
                            matrix[oldRow, oldCol] = '-';
                            if (newCol + 1 >= matrix.GetLength(0))
                            {
                                newCol = 0;
                                if (matrix[newRow, newCol] == 'F')
                                {
                                    matrix[newRow, newCol] = 'f';
                                    isWin = true;
                                    break;
                                }
                                matrix[newRow, newCol] = 'f';
                                RenewValues(newRow, newCol, out oldRow, out oldCol);
                                continue;
                            }

                            matrix[newRow, newCol + 1] = 'f';
                            oldRow = newRow;
                            oldCol = newCol + 1;

                        }
                        else if (matrix[newRow, newCol] == 'T')
                        {
                            continue;
                        }
                        else if (matrix[newRow, newCol] == 'F')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            isWin = true;
                            break;
                        }
                        break;
                    case "left":
                        if (oldCol - 1 < 0)
                        {
                            newRow = oldRow;
                            newCol = matrix.GetLength(1) - 1;
                        }
                        else
                        {
                            newRow = oldRow;
                            newCol = oldCol - 1;
                        }

                        if (matrix[newRow, newCol] == '-')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            RenewValues(newRow, newCol, out oldRow, out oldCol);
                        }
                        else if (matrix[newRow, newCol] == 'B')
                        {
                            matrix[oldRow, oldCol] = '-';
                            if (newCol - 1 < 0)
                            {
                                newCol = matrix.GetLength(0) - 1;
                                if (matrix[newRow, newCol] == 'F')
                                {
                                    matrix[newRow, newCol] = 'f';
                                    isWin = true;
                                    break;
                                }
                                matrix[newRow, newCol] = 'f';
                                RenewValues(newRow, newCol, out oldRow, out oldCol);
                                continue;
                            }

                            matrix[newRow, newCol - 1] = 'f';
                            oldRow = newRow;
                            oldCol = newCol - 1;

                        }
                        else if (matrix[newRow, newCol] == 'T')
                        {
                            continue;
                        }
                        else if (matrix[newRow, newCol] == 'F')
                        {
                            matrix[oldRow, oldCol] = '-';
                            matrix[newRow, newCol] = 'f';
                            isWin = true;
                            break;
                        }
                        break;
                }
            }
            Console.WriteLine(isWin ? $"Player won!" : "Player lost!");
            Print(matrix);
        }

        private static void RenewValues(int newRow, int newCol, out int oldRow, out int oldCol)
        {
            oldRow = newRow;
            oldCol = newCol;
        }


        private static int[] Location(char[,] matrix)
        {
            var location = new int[2];
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    if (matrix[k, l] == 'f')
                    {
                        location = new[] {k, l};
                        break;
                    }
                }
            }

            return location;
        }

        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        private static char[,]  Matrix(int x, int y)
        {
            var matrix = new char[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }

    }
}

    
