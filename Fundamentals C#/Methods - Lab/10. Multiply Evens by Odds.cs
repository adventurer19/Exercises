using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            string result = $"{EvenPlusOdd(x)}";
            Console.WriteLine(result);

        }
        private static int EvenPlusOdd(int x)
        {
            int evenDigits = 0;
            int oddDigits = 0;
            while (Math.Abs(x) != 0)
            {
                int digit = x % 10;
                if (digit % 2 == 0)
                {
                    evenDigits += digit;
                }
                else
                {
                    oddDigits += digit;
                }
                x /= 10;
            }
            int result = evenDigits * oddDigits;
            return result;


        }

    }
}