using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int x = int.MinValue;
            int lenght = numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];
                bool istrue = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];
                    if (rightNumber >= currNumber)
                    {
                        istrue = false;
                        break;
                    }

                }
                if (istrue)
                {
                    Console.Write($"{currNumber} ");
                }
            }
            Console.WriteLine();




        }
    }
}