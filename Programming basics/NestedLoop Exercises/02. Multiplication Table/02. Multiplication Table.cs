using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1 + x2 + x3 = n
            //int num = int.Parse(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
                {

                    Console.WriteLine($"{x} * {y} = {x * y}");

                }
            }

        }
    }
}