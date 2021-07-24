using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Advance
{

    class Program
    {
        static void Main(string[] args)
        {
            int priceOfEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int valueOfIntellegence = int.Parse(Console.ReadLine());
            int counter = 0;
            int bull = 0;
            Stack<int> stackBullets = new Stack<int>(bullets);
            Queue<int> queLocks = new Queue<int>(locks);
            bool whileLoop = true;
            while (whileLoop)
            {
                counter++;
                int lockSize = queLocks.Peek();
                int bullet = stackBullets.Pop();
                if (bullet > lockSize)
                {
                    bull++;
                    Console.WriteLine("Ping!");
                }
                else
                {
                    bull++;
                    queLocks.Dequeue();
                    Console.WriteLine($"Bang!");
                }
                if (bull == sizeOfGunBarrel && stackBullets.Count > 0)
                {
                    bull = 0;
                    Console.WriteLine($"Reloading!");
                }

                whileLoop = (stackBullets.Count > 0 && queLocks.Count > 0);
            }
            if (queLocks.Count <= 0)
            {
                int leftBullets = stackBullets.Count;
                int sum = valueOfIntellegence - (counter * priceOfEachBullet);
                Console.WriteLine($"{leftBullets} bullets left. Earned ${sum}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queLocks.Count}");
            }




        }
    }
}