using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            double sum = 0;
            while (text != "NoMoreMoney")
            {

                double num = double.Parse(text);
                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;

                }
                Console.WriteLine($"Increase: {num:f2}");
                sum += num;
                text = Console.ReadLine();


            }
            Console.WriteLine($"Total: {sum:f2}");


        }
    }
}
