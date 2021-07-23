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
            int BestSize = 0;
            int topNumber = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int leftNum = nums[i];
                int size = 1;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int rightNum = nums[j];
                    if (rightNum == leftNum)
                    {
                        size++;

                    }
                    else
                    {
                        break;
                    }

                }

                if (size > BestSize)
                {
                    BestSize = size;
                    topNumber = nums[i];
                }
            }
            for (int i = 0; i < BestSize; i++)
            {
                Console.Write(topNumber + " ");
            }



        }
    }
}