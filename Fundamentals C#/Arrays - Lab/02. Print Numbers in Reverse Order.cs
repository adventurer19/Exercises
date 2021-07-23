using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[input];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");

            }

        }
    }
}