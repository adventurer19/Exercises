using System;



namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int power = 0; power <= n; power++)
            {
                if (power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, power));
                }

            }
        }
    }
}