using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            pwdValidator(x, a, b);


        }

        private static void pwdValidator(int x, int a, int b)
        {
            int sum = (x + a) - b;
            Console.WriteLine(sum);

        }
    }

}