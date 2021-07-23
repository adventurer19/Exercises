using System;
using System.Linq;

namespace example
{
    class Program
    {
        static void Main()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Result(a, b, c);
        }

        private static void Result(int d, int d1, int d2)
        {
            int[] array = new[] { d, d1, d2 };
            if (array.All(x => x < 0))
            {
                Console.WriteLine("negative");
            }
            else if (array.Any(x => x == 0))
            {
                Console.WriteLine("zero");

            }
            else if (array.Where(x => x > 0).ToArray().Length == 2)
            {
                Console.WriteLine("negative");
            }
            else if (array.All(x => x > 0))
            {
                Console.WriteLine("positive");
            }
            else if (array.Where(x => x < 0).ToArray().Length == 2)
            {
                Console.WriteLine("positive");
            }

        }
    }
}