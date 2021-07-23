using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {

                for (int x = 1; x <= 9; x++)
                {

                    for (int y = 1; y <= 9; y++)
                    {

                        for (int k = 1; k <= 9; k++)
                        {

                            if (num % i != 0) continue;
                            if (num % x != 0) continue;
                            if (num % y != 0) continue;
                            if (num % k != 0) continue;
                            Console.Write($"{i}{x}{y}{k} ");
                        }
                    }
                }
            }








        }
    }
}