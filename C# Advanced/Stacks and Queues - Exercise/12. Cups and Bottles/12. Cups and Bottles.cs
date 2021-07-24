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

            int[] cupCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottofWater = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(cupCapacity);
            Stack<int> water = new Stack<int>(bottofWater);
            int wasted = 0;
            int left = 0;
            while (true)
            {
                int currentWater = water.Peek();
                int currentCups = cups.Peek();
                if (left > 0)
                {
                    currentCups = left;
                    left = 0;
                }
                if (currentWater >= currentCups)
                {
                    wasted += currentWater - currentCups;
                    water.Pop();
                    cups.Dequeue();

                }
                else if (currentWater < currentCups)
                {
                    left = currentCups - currentWater;
                    water.Pop();
                }

                if (cups.Count <= 0 || water.Count <= 0) break;

            }

            string waterResult = $"Wasted litters of water: {wasted}";
            string bottlesOrWater = cups.Count <= 0 ? $"Bottles: {string.Join(' ', water)}" : $"Cups: {string.Join(' ', cups)}";
            Console.WriteLine($"{bottlesOrWater}\n{waterResult}");






        }
    }
}