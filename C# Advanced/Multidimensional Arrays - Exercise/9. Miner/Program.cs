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
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            var field = FillingTheField(dimensions);
            int coal = TotalCoal(field);
            var start = Position(field);
            int[] grind = new[] { 0 };
            bool[] exit = new[] { false };
            for (int i = 0; i < commands.Length; i++)
            {
                string line = commands[i];
                Moving(start, field, grind, line, coal, exit);
                if (exit[0] == true) break;

            }

            if (exit[0] == false)
            {
                Console.WriteLine($"{coal - grind[0]} coals left. ({start[0]}, {start[1]})");
            }


        }

        private static void Moving(int[] start, char[,] field, int[] grind, string line, int coal, bool[] exit)
        {

            int rows = -1;
            int cols = -1;
            if (line == "up")
            {
                rows = start[0] - 1;
                cols = start[1];

            }
            else if (line == "down")
            {
                rows = start[0] + 1;
                cols = start[1];

            }
            else if (line == "right")
            {
                rows = start[0];
                cols = start[1] + 1;
            }
            else if (line == "left")
            {
                rows = start[0];
                cols = start[1] - 1;
            }

            if (IsValid(rows, cols, field))
            {
                char current = field[rows, cols];
                if (current == 'c')
                {
                    grind[0]++;

                    if (grind[0] == coal)
                    {
                        Console.WriteLine($"You collected all coals! ({rows}, {cols})");
                        exit[0] = true;
                        return;

                    }
                    field[rows, cols] = '*';
                }
                else if (current == 'e')
                {
                    Console.WriteLine($"Game over! ({rows}, {cols})");
                    exit[0] = true;

                    return;
                }

                start[0] = rows;
                start[1] = cols;

            }

        }

        private static bool IsValid(int rows, int cols, char[,] field)
        {
            bool result = rows >= 0 && rows < field.GetLength(0) &&
                          cols >= 0 && cols < field.GetLength(0);
            return result;
        }

        private static int TotalCoal(char[,] field)
        {
            int totalCoal = 0;
            foreach (var idx in field)
            {
                if (idx == 'c')
                {
                    totalCoal++;
                }
            }

            return totalCoal;
        }

        private static char[,] FillingTheField(int dimensions)
        {
            char[,] field = new char[dimensions, dimensions];
            // filling the matrix
            for (int i = 0; i < field.GetLength(0); i++)
            {
                char[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = nums[j];
                }
            }

            return field;
        }

        private static int[] Position(char[,] field)
        {
            int[] start = new int[2];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 's')
                    {
                        start[0] = i;
                        start[1] = j;
                    }
                }
            }

            return start;
        }
    }
}
