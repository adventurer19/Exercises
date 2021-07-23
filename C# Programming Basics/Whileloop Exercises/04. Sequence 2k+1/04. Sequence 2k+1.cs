using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = 1;
            // y<=n
            while (n >= y)
            {
                Console.WriteLine(y);
                y = y * 2 + 1;

            }

        }
    }
}
