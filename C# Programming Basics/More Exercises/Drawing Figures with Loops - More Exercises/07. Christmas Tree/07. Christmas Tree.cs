using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            int p = 1;
            for (int i = 0; i <= n; i++)
            {
                for (int space = 0; space < n - i; space++)
                {
                    Console.Write(" ");
                }

                for (int stars = 1; stars < p; stars++)
                {
                    Console.Write("*");
                }
                for (int y = 1; y <= 1; y++)
                {
                    Console.Write(" | ");
                }
                for (int stars2 = 1; stars2 < p; stars2++)
                {
                    Console.Write("*");
                }
                p++;
                Console.WriteLine();
            }






        }
    }
}