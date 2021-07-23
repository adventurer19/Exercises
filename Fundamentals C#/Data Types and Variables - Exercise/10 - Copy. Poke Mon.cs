using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());//power
            int M = int.Parse(Console.ReadLine());//distance
            int Y = int.Parse(Console.ReadLine());//exhaustion
            int x = N;
            int counter = 0;
            while (N >= M)
            {

                N -= M;
                counter++;
                if (N == x / 2 && Y > 0)
                {
                    N /= Y;
                }


            }
            Console.WriteLine(N);
            Console.WriteLine(counter);

        }
    }
}