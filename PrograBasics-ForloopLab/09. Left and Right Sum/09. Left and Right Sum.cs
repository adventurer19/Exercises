using System;



namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            for (int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                firstSum += y;

            }
            int SecondSum = 0;

            for (int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                SecondSum += y;

            }
            if (firstSum == SecondSum)
            {
                Console.WriteLine("Yes, sum = {0}", firstSum);

            }
            else
            {
                int diff = firstSum - SecondSum;
                Console.WriteLine("No, diff = {0}", Math.Abs(diff));
            }
        }

    }
}