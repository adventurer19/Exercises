using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(current + " ");
                    current++;
                    if (current > num) return;
                }

                Console.WriteLine();
            }
        }

    }
}