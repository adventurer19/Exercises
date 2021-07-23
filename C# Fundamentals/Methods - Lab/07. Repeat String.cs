using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {

            string input = Console.ReadLine();
            // double width = double.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            string output = Method(input, counter);
            Console.WriteLine(output);

        }
        private static string Method(string input, int counter)
        {
            string result = string.Empty;
            for (int i = 0; i < counter; i++)
            {
                result += input;
            }
            return result;
        }

    }
}