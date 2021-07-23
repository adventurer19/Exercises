using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = int.MaxValue;
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                int num = int.Parse(text);
                if (num < max)
                {
                    max = num;
                }
                text = Console.ReadLine();


            }

            Console.WriteLine(max);
        }
    }
}
