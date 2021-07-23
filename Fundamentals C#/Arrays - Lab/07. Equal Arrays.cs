using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] arrayone = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arraytwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool result = false;
            int sum = 0;
            int index = 0;
            for (int i = 0; i < arrayone.Length; i++)
            {
                if (arrayone[i] == arraytwo[i])
                {
                    sum += arrayone[i];
                    result = true;
                }
                else
                {
                    index = i;
                    result = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    break;

                }
            }

            if (result)
            {
                Console.WriteLine($"Arrays are identical. Sum: { sum}");
            }
            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // int[] nums = Console.WriteLine().Split

            //Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).toArray();
        }
    }
}