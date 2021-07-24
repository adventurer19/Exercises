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
            Stack<int> numStack = new Stack<int>();
            for (int i = 0; i < line[0]; i++)
            {
                numStack.Push(nums[i]);
            }
            for (int i = 0; i < line[1]; i++)
            {
                numStack.Pop();
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