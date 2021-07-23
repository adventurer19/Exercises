using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {

            //string input = Console.ReadLine().ToLower();
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Method(width, height);
            Console.WriteLine(area);


        }
        private static double Method(double w = 0, double h = 0)
        {
            double area = w * h;
            return area;

        }

    }
}