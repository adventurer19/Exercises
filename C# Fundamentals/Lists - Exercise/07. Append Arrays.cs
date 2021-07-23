using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split('|').ToArray();
            List<int> result = new List<int>(nums.Length);
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                // List<int> x = nums[i].Split(' ').Select(int.Parse).ToList();
                List<int> parts = nums[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                result.AddRange(parts);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}