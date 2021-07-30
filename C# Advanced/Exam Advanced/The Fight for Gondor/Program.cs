using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace The_Fight_for_Gondor
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var plates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var wall = new Queue<int>(plates);
            var invasion = new Stack<int>();
            bool broken = false;
            Invasion(num, ref invasion, ref wall, ref broken);
            Print(broken, invasion, wall);
        }

        private static void Invasion(int num, ref Stack<int> invasion, ref Queue<int> wall, ref bool broken)
        {
            for (int i = 1; i <= num; i++)
            {
                var orcs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();
                invasion = new Stack<int>(orcs);
                if (i % 3 == 0)
                {
                    var rebuild = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                        .ToArray();
                    foreach (var item in rebuild)
                    {
                        wall.Enqueue(item);
                    }
                }

                While(invasion, ref wall);
                if (wall.Count == 0)
                {
                    broken = true;
                    break;
                }
            }
        }

        private static void While(Stack<int> invasion, ref Queue<int> wall)
        {
            while (invasion.Count > 0 && wall.Count > 0)
            {
                if (invasion.Peek() > wall.Peek())
                {
                    invasion.Push(invasion.Pop() - wall.Peek());
                    wall.Dequeue();
                }
                else if (invasion.Peek() < wall.Peek())
                {
                    int value = wall.Dequeue() - invasion.Pop();
                    wall = new Queue<int>(wall.Reverse());
                    wall.Enqueue(value);
                    wall = new Queue<int>(wall.Reverse());
                }
                else if (invasion.Peek() == wall.Peek())
                {
                    invasion.Pop();
                    wall.Dequeue();
                }
            }
        }

        private static void Print(bool broken, Stack<int> invasion, Queue<int> wall)
        {
            if (broken)
            {
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", invasion)}");
            }
            else
            {
                Console.WriteLine($"The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", wall)}");
            }
        }
    }
}
