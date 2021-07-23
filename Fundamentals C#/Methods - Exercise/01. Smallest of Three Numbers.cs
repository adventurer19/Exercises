using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string result = small(x, a, b);
            Console.WriteLine(result);

        }
        private static string small(int x, int a, int b)
        {
            int[] nums = { x, a, b };
            Array.Sort(nums);
            string result = $"{nums[0]}";
            return result;




        }

    }
}