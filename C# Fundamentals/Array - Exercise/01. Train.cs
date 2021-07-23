using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // int[] inputArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] array2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in array2)
            {
                foreach (var item2 in array)
                {

                    if (item == item2)
                    {
                        Console.Write(item2 + " ");
                    }
                }
            }
            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // int[] nums = Console.WriteLine().Split

            //Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).toArray();
        }
    }
}