using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {


            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Length; i++)
            {

                int left = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int right = nums[j];
                    if (left + right == x)
                    {
                        Console.WriteLine($"{left} {right} ");
                        break;
                    }

                }

            }





        }
    }
}