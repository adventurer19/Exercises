using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            if (num % 2 == 0)
                Console.WriteLine("The number is: {0} ", Math.Abs(num));

        }
    }
}