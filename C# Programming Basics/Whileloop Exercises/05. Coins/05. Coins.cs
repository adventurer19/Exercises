using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 st / 2st //5st/ 10 st/ 20st /50st /1lv /2lv;
            double sumgiven = double.Parse(Console.ReadLine());
            double convert = sumgiven * 100;
            int cents = (int)convert;
            int coins = 0;
            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    coins++;
                    cents -= 200;
                }
                else if (cents - 100 >= 0)
                {
                    coins++;
                    cents -= 100;
                }
                else if (cents - 50 >= 0)
                {
                    coins++;
                    cents -= 50;
                }
                else if (cents - 20 >= 0)
                {
                    coins++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    coins++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    coins++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    coins++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    coins++;
                    cents -= 1;
                }
            }

            Console.WriteLine(coins);





        }
    }
}