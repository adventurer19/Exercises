using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double y = int.Parse(Console.ReadLine());
            string result = $"{Math.Round(MathOperations(x, operation, y), 2)}";
            Console.WriteLine(result);


        }
        private static double MathOperations(double a, string operation, double b)
        {
            double result = 0;
            if (operation == "/") result = a / b;
            else if (operation == "*") result = a * b;
            else if (operation == "-") result = a - b;
            else if (operation == "+") result = a + b;
            return result;




        }

    }
}