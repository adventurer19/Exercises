using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Array.Reverse(line);
            Console.WriteLine(string.Join(' ', line));
        }
    }
}