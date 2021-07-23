using System;
using System.Numerics;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                int box = 0;
                int days = 0;
                for (int i = yield; i >= 100; i -= 10)
                {
                    days++;
                    box += i - 26;


                }
                box -= 26;
                Console.WriteLine(days);
                Console.WriteLine(box);
            }


        }
    }
}