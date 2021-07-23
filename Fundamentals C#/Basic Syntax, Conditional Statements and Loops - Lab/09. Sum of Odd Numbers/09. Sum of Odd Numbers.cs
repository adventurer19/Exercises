using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            double sum = 0;
            int counter = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                if (counter < num)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
                counter++;
            }
            Console.WriteLine("Sum: {0}", sum);

        }
    }
}