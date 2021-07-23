using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = nums[0];
            int area = nums[1];
            while (numbers.Contains(bomb))
            {
                List<int> output = new List<int>();
                int indexOfBomb = numbers.FindIndex(n => n == bomb);
                int leftEnd = indexOfBomb - area;
                int rightEnd = indexOfBomb + area + 1;
                for (int i = 0; i < leftEnd; i++)
                {
                    output.Add(numbers[i]);

                }

                for (int i = rightEnd; i < numbers.Count; i++)
                {
                    output.Add(numbers[i]);
                }

                numbers = output;

            }

            int sumOfNumbers = numbers.Sum();
            Console.WriteLine(sumOfNumbers);





        }
    }
}