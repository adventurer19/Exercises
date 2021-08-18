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
            char[,] matrixChar = new char[array[0], array[1]];
            for (int i = 0; i < matrixChar.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < matrixChar.GetLength(1); j++)
                {
                    matrixChar[i, j] = input[j];
                }

            }

            int counter = 0;
            for (int i = 0; i < matrixChar.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrixChar.GetLength(1) - 1; j++)
                {
                    if (matrixChar[i, j] == matrixChar[i, j + 1] &&
                        matrixChar[i, j] == matrixChar[i + 1, j] &&
                        matrixChar[i, j] == matrixChar[i + 1, j + 1])
                    {
                        counter++;
                    }

                }
            }

            Console.WriteLine(counter);

        }

        private static int[] ArrayReadInt()
        {
            int[] arrayInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return arrayInput;
        }


        private static int[,] Matrix(int x)
        {
            int[,] matrix = new int[x, x];
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