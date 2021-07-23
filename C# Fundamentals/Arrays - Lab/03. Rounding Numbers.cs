using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] round = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                round[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(numbers[i])} => {Convert.ToDecimal(round[i])}");
            }

        }
    }
}