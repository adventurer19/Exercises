using System;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    counter++;
                    sum += num;
                }

            }
            Console.WriteLine($"{sum / counter:f2}");




        }
    }
}