using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool exist = false;
            for (int i = 0; i < numbers.Length; i++)
            {


                int leftSum = 0;
                for (int leftNumbers = i - 1; leftNumbers >= 0; leftNumbers--)
                {
                    leftSum += numbers[leftNumbers];
                }
                int rightSum = 0;
                for (int rightNumbers = i + 1; rightNumbers < numbers.Length; rightNumbers++)
                {
                    rightSum += numbers[rightNumbers];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    exist = true;
                    break;
                }

            }
            if (!exist)
            {
                Console.WriteLine("no");
            }




        }
    }
}