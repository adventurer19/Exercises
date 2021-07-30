using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int[] two = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(one); //hats
            var que = new Queue<int>(two); // scarf
            var list = new List<int>();
            while (que.Count>0 && stack.Count>0)
            {
                if (stack.Peek() > que.Peek())
                {
                    int sum = stack.Pop() + que.Dequeue();
                    list.Add(sum);
                }
                else if (stack.Peek() == que.Peek())
                {
                    stack.Push(stack.Pop()+1);
                    que.Dequeue();
                }
                else if (stack.Peek() < que.Peek())
                {
                    stack.Pop();
                }
            }

            Console.WriteLine($"The most expensive set is: {list.Max()}");
            Console.WriteLine(string.Join(' ',list));


        }
    }
}
