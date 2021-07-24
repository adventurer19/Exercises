using System;
using System.Linq;
using System.Collections.Generic;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            uint days = uint.Parse(Console.ReadLine());
            uint daily = uint.Parse(Console.ReadLine());
            float total = float.Parse(Console.ReadLine());
            double gains = 0;
            for (int i = 1; i <= days; i++)
            {
                gains += daily;
                if (i % 3 == 0)
                {
                    gains += daily * 0.5;
                }
                if (i % 5 == 0)
                {
                    gains -= gains * 0.3;
                }

            }

            if (total <= gains)
            {
                Console.WriteLine($"Ahoy! {gains:f2} plunder gained.");
            }
            else if (total > gains)
            {

                Console.WriteLine($"Collected only {gains / total * 100:f2}% of the plunder.");
            }







        }

    }
}