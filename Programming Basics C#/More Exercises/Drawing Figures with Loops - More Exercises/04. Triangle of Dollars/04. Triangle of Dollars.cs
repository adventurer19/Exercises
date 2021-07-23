using System;

namespace traning
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int t = 0;
            for (int i = 1; i <= x; i++)
            {
                t++;
                for (int y = 1; y <= t; y++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }






        }
    }
}