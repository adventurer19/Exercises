using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Advance
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayReadInt();
            string[,] matrix = new string[array[0], array[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];

                }
            }

            string line = String.Empty;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] tokens = line.Split(' ').ToArray();
                if (tokens.Length == 5 && tokens[0] == "swap" &&
                    int.Parse(tokens[1]) < array[0] &&
                    int.Parse(tokens[2]) < array[1])
                {
                    int first = int.Parse(tokens[1]);
                    int second = int.Parse(tokens[2]);
                    int third = int.Parse(tokens[3]);
                    int fourth = int.Parse(tokens[4]);
                    string temp = matrix[first, second];
                    matrix[first, second] = matrix[third, fourth];
                    matrix[third, fourth] = temp;
                    PrintResult(matrix);
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }


            }



        }

        private static void PrintResult(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static int[] ArrayReadInt()
        {
            int[] arrayInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return arrayInput;
        }


        private static int[,] Matrix(int x, int y)
        {
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
    }

}