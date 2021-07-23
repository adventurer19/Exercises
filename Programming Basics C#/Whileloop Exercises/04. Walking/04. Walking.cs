using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            int step = 0;

            string text = Console.ReadLine();
            while (text != "Going home")
            {
                step += int.Parse(text);

                if (step > n)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{step - n} steps over the goal!");
                    return;
                }
                text = Console.ReadLine();

            }
            int laststeps = int.Parse(Console.ReadLine());
            int y = laststeps + step - n;
            if (laststeps + step < n)
            {

                Console.WriteLine($"{Math.Abs(y)} more steps to reach goal.");
            }
            else
            {

                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{y} steps over the goal!");

            }





        }
    }
}