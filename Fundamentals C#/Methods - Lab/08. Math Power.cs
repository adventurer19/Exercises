using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {

            double inputLineOne = double.Parse(Console.ReadLine());
            double inputLineTwo = double.Parse(Console.ReadLine());
            string result = Method(inputLineOne, inputLineTwo);
            Console.WriteLine(result);

        }
        private static string Method(double input1, double input2)
        {
            //  string result = string.Empty;           
            double y = input1;
            for (int i = 1; i < input2; i++)
            {
                double x = y;
                y = x * input1;
            }
            string result = $"{y}";
            return result;
        }

    }
}