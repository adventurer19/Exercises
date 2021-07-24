using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (line[0] == 0)
            {
                Console.WriteLine("0");
                return;

            }
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numStack = new Queue<int>();
            for (int i = 0; i < line[0]; i++)
            {
                numStack.Enqueue(nums[i]);
            }
            for (int i = 0; i < line[1]; i++)
            {
                numStack.Dequeue();
            }

            if (numStack.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }
            bool flag = numStack.Contains(line[2]);
            Console.WriteLine(flag ? "true" : $"{numStack.Min()}");




        }
    }



}