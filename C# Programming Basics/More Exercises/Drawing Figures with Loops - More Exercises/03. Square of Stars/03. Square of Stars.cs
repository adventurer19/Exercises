using System;

namespace traning
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int t = 0; t < x; t++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }






        }
    }
}