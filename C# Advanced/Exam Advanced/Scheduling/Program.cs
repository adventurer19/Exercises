using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var threads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int taskValue = int.Parse(Console.ReadLine());
            var thread= new Queue<int>(threads);
            var task = new Stack<int>(tasks);
            while (thread.Count>0 && task.Count>0)
            {
                if (task.Peek() == taskValue)
                {
                    Console.WriteLine($"Thread with value {thread.Peek()} killed task {taskValue}");
                    break;
                }
                var a = thread.Peek();
                var b = task.Peek();
                if (thread.Peek() >= task.Peek())
                {
                    thread.Dequeue();
                    task.Pop();
                }
                else if(thread.Peek()<task.Peek())
                {
                    thread.Dequeue();
                }

            }
            Console.WriteLine($"{string.Join(' ',thread)}");

        }
    }
}
