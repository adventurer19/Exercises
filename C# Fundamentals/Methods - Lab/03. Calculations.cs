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
            int y = int.Parse(Console.ReadLine());
            string result = Method(input, x, y);
            Console.WriteLine(result);


        }
        private static string Method(string input = null, int x = 0, int y = 0)
        {
            string output = string.Empty;
            if (input == "add") output = $"{x + y}";
            else if (input == "multiply") output = $"{x * y}";
            else if (input == "subtract") output = $"{x - y}";
            else if (input == "divide") output = $"{x / y}";
            return output;


        }

    }
}