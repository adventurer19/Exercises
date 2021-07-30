using System;
using System.Linq;

namespace SuperMarioMatrix
{
    public class Mario
    {
        public int life { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public int nextRow { get; set; }
        public int nextCol { get; set; }
        public bool savedOrDead { get; set; }
        public Mario(int live, char[,] matrix)
        {
            life = live;
            Row = -1;
            Col = -1;
            nextRow = -1;
            nextCol = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'M')
                    {
                        Row = i;
                        Col = j;

                    }
                }

            }
            savedOrDead = false;
        }
        public static bool ValidationIdx(int row, int col, char[,] matrix)
        {
            bool condition = row >= 0 && col >= 0 && col < matrix.GetLength(1) && row < matrix.GetLength(0);
            return condition;
        }
        public void Up(char[,] matrix)
        {
            nextRow = Row - 1;
            nextCol = Col;
            life--;
            if (ValidationIdx(nextRow, nextCol, matrix))
            {
                matrix[Row, Col] = '-';
                if (matrix[nextRow, nextCol] == '-')
                {
                    matrix[nextRow, nextCol] = 'M';
                }
                else if (matrix[nextRow, nextCol] == 'P')
                {
                    savedOrDead = true;
                    matrix[nextRow, nextCol] = '-';
                }
                else if (matrix[nextRow, nextCol] == 'B')
                {
                    life -= 2;
                    matrix[nextRow, nextCol] = 'M';
                }
                Row = nextRow;
                Col = nextCol;
            }
        }
        public void Down(char[,] matrix)
        {
            nextRow = Row + 1;
            nextCol = Col;
            life--;
            if (ValidationIdx(nextRow, nextCol, matrix))
            {
                matrix[Row, Col] = '-';
                if (matrix[nextRow, nextCol] == '-')
                {
                    matrix[nextRow, nextCol] = 'M';
                }
                else if (matrix[nextRow, nextCol] == 'P')
                {
                    savedOrDead = true;
                    matrix[nextRow, nextCol] = '-';
                }
                else if (matrix[nextRow, nextCol] == 'B')
                {
                    life -= 2;
                    matrix[nextRow, nextCol] = 'M';
                }
                Row = nextRow;
                Col = nextCol;
            }

        }
        public void Right(char[,] matrix)
        {
            nextRow = Row;
            nextCol = Col + 1;
            life--;
            if (ValidationIdx(nextRow, nextCol, matrix))
            {
                matrix[Row, Col] = '-';
                if (matrix[nextRow, nextCol] == '-')
                {
                    matrix[nextRow, nextCol] = 'M';
                }
                else if (matrix[nextRow, nextCol] == 'P')
                {
                    savedOrDead = true;
                    matrix[nextRow, nextCol] = '-';
                }
                else if (matrix[nextRow, nextCol] == 'B')
                {
                    life -= 2;
                    matrix[nextRow, nextCol] = 'M';
                }
                Row = nextRow;
                Col = nextCol;
            }

        }
        public void Left(char[,] matrix)
        {
            nextRow = Row;
            nextCol = Col - 1;
            life--;
            if (ValidationIdx(nextRow, nextCol, matrix))
            {
                matrix[Row, Col] = '-';
                if (matrix[nextRow, nextCol] == '-')
                {
                    matrix[nextRow, nextCol] = 'M';
                }
                else if (matrix[nextRow, nextCol] == 'P')
                {
                    savedOrDead = true;
                    matrix[nextRow, nextCol] = '-';
                }
                else if (matrix[nextRow, nextCol] == 'B')
                {
                    life -= 2;
                    matrix[nextRow, nextCol] = 'M';
                }
                Row = nextRow;
                Col = nextCol;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var life = int.Parse(Console.ReadLine());
            var matrix = Matrix();
            var Mario = new Mario(life, matrix);
            if (Mario == null) return;
            while (Mario.life > 0)
            {

                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                SpawnEnemy(int.Parse(line[1]), int.Parse(line[2]), matrix);
                if (line[0] == "W")
                {
                    Mario.Up(matrix);
                }
                else if (line[0] == "S")
                {
                    Mario.Down(matrix);
                }
                else if (line[0] == "A")
                {
                    Mario.Left(matrix);
                }
                else if (line[0] == "D")
                {
                    Mario.Right(matrix);
                }
                if (Mario.savedOrDead) break;
                if (Mario.life <= 0)
                {
                    matrix[Mario.Row, Mario.Col] = 'X';
                    break;
                }

            }
            if (Mario.savedOrDead)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {Mario.life}");
            }
            else
            {
                Console.WriteLine($"Mario died at {Mario.Row};{Mario.Col}.");
            }
            Print(matrix);


        }



        public static bool ValidationIdx(int row, int col, char[,] matrix)
        {
            bool condition = row >= 0 && col >= 0 && col < matrix.GetLength(1) && row < matrix.GetLength(0);
            return condition;
        }

        private static void SpawnEnemy(int row, int col, char[,] matrix)
        {
            if (ValidationIdx(row, col, matrix))
            {
                matrix[row, col] = 'B';
                //if (matrix[row, col] == '-')
                //{

                //}
            }

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

        private static char[,] Matrix()
        {
            int rows = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().ToCharArray();
            char[,] matrix = new char[rows, input.Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
                if (i == matrix.GetLength(0) - 1) break;
                input = Console.ReadLine().ToCharArray();
            }

            return matrix;
        }
    }
}
