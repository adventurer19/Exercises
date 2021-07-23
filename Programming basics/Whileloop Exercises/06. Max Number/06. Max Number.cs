using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = int.MinValue;
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                int num = int.Parse(text);
                if (num > max)
                {
                    max = num;
                }
                text = Console.ReadLine();


            }

            Console.WriteLine(max);
        }
    }
}
