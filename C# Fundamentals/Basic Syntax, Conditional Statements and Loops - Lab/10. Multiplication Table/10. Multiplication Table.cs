using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                int sum = i * num;
                Console.WriteLine("{0} X {1} = {2}", num, i, sum);
            }


        }
    }
}