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

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int amount = 0;
            int bags = 1;
            Stack<int> nums = new Stack<int>(numbers);
            while (nums.Count > 0)
            {
                amount += nums.Peek();
                if (amount <= capacity)
                {
                    nums.Pop();

                }
                else
                {
                    bags++;
                    amount = 0;
                }
            }

            Console.WriteLine(bags);
        }
    }



}