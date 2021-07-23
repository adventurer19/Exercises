using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        bool[] numbersRemoved = new bool[numbers.Length];
        while (true)
        {
            bool foundAdjacent = false;
            int index = 0;
            while (index < numbers.Length - 1)
            {
                if (numbersRemoved[index])
                {
                    index++;
                    continue;
                }

                var nextFreeIndex = index + 1;
                for (int j = index + 1; j < numbers.Length - 1 && numbersRemoved[j]; j++)
                {
                    nextFreeIndex = j + 1;
                }

                if (numbersRemoved[nextFreeIndex])
                {
                    break;
                }
                if (numbers[index] == numbers[nextFreeIndex])
                {
                    numbers[index] += numbers[index];
                    numbersRemoved[nextFreeIndex] = true;
                    foundAdjacent = true;
                }

                index = nextFreeIndex;
            }

            if (!foundAdjacent)
            {
                break;
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbersRemoved[i])
            {
                continue;
            }
            Console.Write($"{numbers[i]} ");
        }

    }
}