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
            Output(x);


        }
        static void Output(int y)
        {

            if (y > 0) Console.WriteLine($"The number {y} is positive.");
            else if (y < 0) Console.WriteLine($"The number {y} is negative.");
            else
            {
                Console.WriteLine($"The number {y} is zero.");
            }
        }

    }
}