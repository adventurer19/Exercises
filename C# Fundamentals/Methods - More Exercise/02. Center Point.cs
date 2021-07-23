using System;
using System.Linq;
using System.Collections.Generic;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double sumOne = GetLower(a, b);
            double sumTwo = GetLower(c, d);
            if (sumOne > sumTwo)
            {
                Console.WriteLine($"({c}, {d})");
            }
            else if (sumOne <= sumTwo)
            {
                Console.WriteLine($"({a}, {b})");
            }


        }

        private static double GetLower(double i, double i1)
        {
            double amount = Math.Abs(i) + Math.Abs(i1);
            return amount;
        }
    }


}