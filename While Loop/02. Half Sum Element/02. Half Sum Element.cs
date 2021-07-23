using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }

            }
            int result = sum - max;
            if (result == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = result - max;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");

            }







        }

    }


}