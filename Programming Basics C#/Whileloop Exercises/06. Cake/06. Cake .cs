using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakeS = lenght * width;
            string text = Console.ReadLine();
            while (text != "STOP")
            {
                int pieces = int.Parse(text);
                cakeS -= pieces;
                if (cakeS <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeS)} pieces more.");
                    return;
                }
                text = Console.ReadLine();

            }
            Console.WriteLine($"{cakeS} pieces are left.");



        }
    }
}