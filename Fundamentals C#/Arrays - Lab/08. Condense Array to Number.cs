using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] condenseArray = new int[inputArray.Length - 1];
            int count = inputArray.Length;
            int count2 = condenseArray.Length;
            if (inputArray.Length == 1)
            {
                Console.WriteLine(inputArray[0]);
                return;
            }
            while (count > 0)
            {
                for (int i = 0; i < count2; i++)
                {
                    condenseArray[i] = inputArray[i] + inputArray[i + 1];
                }
                count--;
                count2--;
                inputArray = condenseArray;

            }
            Console.WriteLine(condenseArray[0]);
            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // int[] nums = Console.WriteLine().Split

            //Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).toArray();
        }
    }
}