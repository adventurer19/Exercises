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

            var dim = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[dim[0],dim[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int primary = 0;
            int secondary = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primary += matrix[i, i];
                secondary += matrix[i, matrix.GetLength(0) - i - 1];
            }

            int result = Math.Abs(primary - secondary);

            Console.WriteLine(result);
        }
    }

}