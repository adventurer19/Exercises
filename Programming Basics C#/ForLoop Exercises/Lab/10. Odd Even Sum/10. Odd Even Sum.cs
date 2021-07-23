using System;



namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += number;
                }
                if (i % 2 != 0)
                {
                    odd += number;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else if (odd != even)
            {
                int diff = 0;
                diff = odd - even;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }



        }

    }


}