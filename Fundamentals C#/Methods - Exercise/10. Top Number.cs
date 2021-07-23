using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            topNum(num);
        }

        private static void topNum(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (Digits(i)) Console.WriteLine(i);
            }
        }

        private static bool Digits(int i)
        {
            int digits = 0;
            bool isOdd = false;
            while (i != 0)
            {
                int x = i % 10;
                if (x % 2 != 0) isOdd = true;
                digits += x;
                i /= 10;

            }
            if (digits % 8 == 0 && isOdd)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }

}