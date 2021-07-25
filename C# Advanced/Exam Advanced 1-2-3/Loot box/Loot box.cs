using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var second = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            Queue<int> firstBox = new Queue<int>(first);
            Stack<int> secondBox = new Stack<int>(second);
            int counter = Math.Max(firstBox.Count, secondBox.Count);
            int sum = 0;
            for (int i = 0; i < counter; i++)
            {
                if (firstBox.Count == 0 || secondBox.Count == 0)
                {
                    break;
                }

                int y = firstBox.Peek();
                int x = secondBox.Peek();
                int amount = x + y;
                if (amount % 2 == 0)
                {
                    sum += amount;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    secondBox.Pop();
                    firstBox.Enqueue(x);
                }
            }

            Console.WriteLine(firstBox.Count==0 ? "First lootbox is empty" : "Second lootbox is empty");
            string epic = $"Your loot was epic! Value: {sum}";
            string low = $"Your loot was poor... Value: {sum}";
            Console.WriteLine(sum>=100 ? epic :low);
        }
    }
}
