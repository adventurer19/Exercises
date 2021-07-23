using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {

            string input = Console.ReadLine().ToLower();
            int x = int.Parse(Console.ReadLine());
            // int y = int.Parse(Console.ReadLine());
            string result = Method(input, x);
            Console.WriteLine(result);


        }
        private static string Method(string input = null, int x = 0)
        {
            string output = string.Empty;
            if (input == "water") output = $"{x * 1.00:f2}";
            else if (input == "coffee") output = $"{x * 1.50:f2}";
            else if (input == "coke") output = $"{x * 1.40:f2}";
            else if (input == "snacks") output = $"{x * 2.00:f2}";
            return output;


        }

    }
}