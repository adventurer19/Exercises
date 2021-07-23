using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1 + x2 + x3 = n

            int n = int.Parse(Console.ReadLine());
            int validCombinationsCount = 0;
            for (int x = 0; x <= n; x++)
            {
                for (int y = 0; y <= n; y++)
                {

                    for (int a = 0; a <= n; a++)
                    {
                        if (x + y + a == n)
                        {
                            validCombinationsCount++;

                        }
                    }

                }
            }
            Console.WriteLine(validCombinationsCount);
        }
    }
}
