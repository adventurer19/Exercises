using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var lily = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rose = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var roses = new Queue<int>(rose);
            var lilies = new Stack<int>(lily);
            var wreaths = 0;
            int leftFlowers = 0;
            while (roses.Count > 0 && lilies.Count > 0)
            {
                if (roses.Peek() + lilies.Peek() == 15)
                {
                    wreaths++;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else if (roses.Peek() + lilies.Peek() > 15)
                {
                    lilies.Push(lilies.Pop() - 2);
                }
                else if (roses.Peek() + lilies.Peek() < 15)
                {
                    leftFlowers += roses.Dequeue() + lilies.Pop();
                }
            }

            wreaths += leftFlowers / 15;

            Console.WriteLine(wreaths >= 5
                ? $"You made it, you are going to the competition with 5 wreaths!"
                : $"You didn't make it, you need {5 - wreaths} wreaths more!");

        }
    }
}
