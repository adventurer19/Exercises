using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            for (int up = 1; up <= 1; up++)
            {
                for (int stars = n * 2; stars > 0; stars--)
                {
                    Console.Write("*");

                }
                for (int space = n; space > 0; space--)
                {
                    Console.Write(" ");
                }
                for (int stars = n * 2; stars > 0; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int rows = 0; rows < n - 2; rows++)
            {
                for (int stars = 1; stars <= 1; stars++)
                {
                    Console.Write("*");
                }
                for (int dash = 2 * n - 2; dash > 0; dash--)
                {
                    Console.Write("/");
                }
                for (int stars = 1; stars <= 1; stars++)
                {
                    Console.Write("*");
                }

                if (rows == (n - 1) / 2 - 1)
                {
                    for (int vert = n; vert > 0; vert--)
                    {
                        Console.Write("|");
                    }
                }
                else
                {
                    for (int space = n; space > 0; space--)
                    {
                        Console.Write(" ");
                    }

                }

                for (int stars = 1; stars <= 1; stars++)
                {
                    Console.Write("*");
                }
                for (int dash = 2 * n - 2; dash > 0; dash--)
                {
                    Console.Write("/");
                }
                for (int stars = 1; stars <= 1; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int up = 1; up <= 1; up++)
            {
                for (int stars = n * 2; stars > 0; stars--)
                {
                    Console.Write("*");

                }
                for (int space = n; space > 0; space--)
                {
                    Console.Write(" ");
                }
                for (int stars = n * 2; stars > 0; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }




        }
    }
}