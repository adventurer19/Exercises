using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            //int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] array = Console.ReadLine().
                Split(' ', StringSplitOptions.
                    RemoveEmptyEntries).
                ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int k = 0; k < n; k++)
            {
                string firstElement = array[0];


                for (int i = 1; i < array.Length; i++)
                {
                    int prevIndex = i - 1;
                    array[prevIndex] = array[i];

                }
                array[array.Length - 1] = firstElement;

            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

        }
    }
}