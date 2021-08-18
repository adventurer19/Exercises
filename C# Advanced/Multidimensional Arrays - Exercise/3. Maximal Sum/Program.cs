using System;
using System.ComponentModel;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dim = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int RowStart = 0;
            int ColStart = 0;
            int[,] matrix = new int[dim[0], dim[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int min = Int32.MinValue;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + 2 < matrix.GetLength(0) && j + 2 < matrix.GetLength(1))
                    {


                        sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                              + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]

                              + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    }
                    if (min < sum)
                    {
                        min = sum;
                        RowStart = i;
                        ColStart = j;

                    }



                }


            }
            Console.WriteLine($"Sum = {min}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[RowStart+i,ColStart+j]} ");
                }

                Console.WriteLine();
            }

           


            
        }
    }
}
