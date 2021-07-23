using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // int[] inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] line = new int[n];
            int[] line2 = new int[n];
            for (int i = 0; i < n; i++)
            {

                int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (i % 2 == 0)
                    {
                        line[i] = array[j];
                        line2[i] = array[j + 1];
                    }
                    else if (i % 2 != 0)
                    {
                        line[i] = array[j + 1];
                        line2[i] = array[j];
                    }

                }
            }
            Console.WriteLine(string.Join(' ', line));
            Console.WriteLine(string.Join(' ', line2));
            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // int[] nums = Console.WriteLine().Split

            //Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).toArray();
        }
    }
}