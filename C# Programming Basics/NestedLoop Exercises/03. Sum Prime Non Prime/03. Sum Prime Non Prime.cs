using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int prime = 0;
            int nonprime = 0;

            while (x != "stop")
            {
                int num = int.Parse(x);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int counter = 0;
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2) prime += num;
                    else nonprime += num;


                }
                x = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprime}");
        }
    }
}