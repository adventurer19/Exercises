using System;

namespace multiply_table
{
    class Program
    {
        static void Main()
        {


            int coinsOne = int.Parse(Console.ReadLine());
            int coinsTwo = int.Parse(Console.ReadLine());
            int coinsFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int counter = 0;
            int counter2 = 0;
            int counter3 = 0;

            for (int i = 0; i <= coinsOne; i++)
            {

                for (int f = 0; f <= coinsTwo; f++)
                {

                    for (int g = 0; g <= coinsFive; g++)
                    {

                        counter = i * 1 + f * 2 + g * 5;
                        if (counter != sum) continue;
                        {
                            Console.WriteLine($"{i} * 1 lv. + {f} * 2 lv. + {g} * 5 lv. = {sum} lv.");

                        }


                    }
                }
            }




        }
    }
}