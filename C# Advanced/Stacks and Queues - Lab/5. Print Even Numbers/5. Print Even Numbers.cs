using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace example
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            int counter = nums.Length;
            for (int i = 0; i < counter; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    numbers.Enqueue(nums[i]);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));



        }


    }



}