using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] arrays = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int odd = 0;
            int even = 0;
            for (int i = 0; i < arrays.Length; i++)
            {

                if (arrays[i] % 2 == 0)
                {
                    even += arrays[i];
                }
                else
                {
                    odd += arrays[i];
                }



            }
            Console.WriteLine(even - odd);

            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // int[] nums = Console.WriteLine().Split

            //Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).toArray();
        }
    }
}