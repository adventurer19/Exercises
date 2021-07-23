using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            int o = n;
            int b = n;
            int t = n;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int space = o - 1; space > 0; space--)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= rows; stars++)
                {
                    Console.Write("* ");

                }
                //x++;
                o--;
                Console.WriteLine();

            }
            for (int rows = 1; rows < n; rows++)
            {
                //n=3;
                for (int space = 1; space <= rows; space++)
                {
                    Console.Write(" ");
                }
                //stars = 3
                for (int stars = 1; stars <= b - 1; stars++)
                {
                    // t--;
                    Console.Write("* ");
                }
                b--;
                Console.WriteLine();
            }






        }
    }
}