using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var bombType = BombType();
            var bombs = SortedDictionary();
            var effects = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var casings = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var que = new Queue<int>(effects);
            var stack = new Stack<int>(casings);
            bool fill = false;
            while (que.Count>0 && stack.Count>0)
            {
                int value = que.Peek() + stack.Peek();
                if (bombType.ContainsKey(value))
                {
                    var currentBomb = bombType[value];
                    bombs[currentBomb]++;
                    que.Dequeue();
                    stack.Pop();

                }
                else
                {
                    stack.Push(stack.Pop()-5);
                }

                fill = bombs.All(x => x.Value >= 3);
                if (fill)
                {
                    break;
                }
            }

            Print(fill, que, stack, bombs);
        }

        private static void Print(bool fill, Queue<int> que, Stack<int> stack, SortedDictionary<string, int> bombs)
        {
            Console.WriteLine(fill
                ? "Bene! You have successfully filled the bomb pouch!"
                : "You don't have enough materials to fill the bomb pouch.");
            Console.WriteLine(que.Count == 0 ? "Bomb Effects: empty" : $"Bomb Effects: {string.Join(", ", que)}");
            Console.WriteLine(stack.Count == 0 ? "Bomb Casings: empty" : $"Bomb Casings: {string.Join(", ", stack)}");
            foreach (var item in bombs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static Dictionary<int, string> BombType()
        {
            var bombType = new Dictionary<int, string>()
            {
                {40, "Datura Bombs"},
                {120, "Smoke Decoy Bombs"},
                {60, "Cherry Bombs"},
            };
            return bombType;
        }

        private static SortedDictionary<string, int> SortedDictionary()
        {
            var bombs = new SortedDictionary<string, int>()
            {
                {"Datura Bombs", 0},
                {"Smoke Decoy Bombs", 0},
                {"Cherry Bombs", 0},
            };
            return bombs;
        }
    }
}
