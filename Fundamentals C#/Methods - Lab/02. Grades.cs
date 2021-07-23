using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            string result = PrintInWords(grade);

            Console.WriteLine(result);


        }
        private static string PrintInWords(double grade)
        {
            string result = string.Empty;
            if (grade >= 2.00 && grade <= 2.99) result = "Fail";
            else if (grade >= 3.00 && grade <= 3.49) result = "Poor";
            else if (grade >= 3.50 && grade <= 4.49) result = "Good";
            else if (grade >= 4.50 && grade <= 5.49) result = "Very good";
            else if (grade >= 5.50 && grade <= 6.00) result = "Excellent";
            return result;


        }

    }
}