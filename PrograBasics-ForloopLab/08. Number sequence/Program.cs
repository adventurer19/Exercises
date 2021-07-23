using System;



namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = -100000;
            int min = 1000000;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }

            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }

    }
}