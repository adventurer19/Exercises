using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int timer = int.Parse(Console.ReadLine());

            do
            {
                int sum = num * timer;
                Console.WriteLine("{0} X {1} = {2}", num, timer, sum);
                timer++;
            } while (timer <= 10);



        }
    }
}