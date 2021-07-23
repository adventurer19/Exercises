using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double result = Factorial(x) / Factorial(b);
            Console.WriteLine($"{result:f2}");


        }

        private static double Factorial(int x)
        {
            double sum = x;

            for (int i = 1; i < x; i++)
            {
                sum *= i;

            }
            return sum;
        }



    }

}