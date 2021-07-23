using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            PrintInWords(x);



        }
        private static void PrintInWords(int x = 0)
        {

            for (int i = 1; i <= x; i++)
            {
                for (int ij = 1; ij <= i; ij++)
                {
                    Console.Write($"{ij} ");
                }
                Console.WriteLine();

            }
            for (int i = x - 1; i > 0; i--)
            {
                for (int ki = 1; ki <= i; ki++)
                {
                    Console.Write(ki + " ");

                }
                Console.WriteLine();
            }


        }

    }
}