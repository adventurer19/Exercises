using System;

namespace blq_blq
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double sum = 0;
            while (num >= sum)
            {
                double currentsum = double.Parse(Console.ReadLine());
                sum += currentsum;

            }
            Console.WriteLine(sum);
        }
    }
}