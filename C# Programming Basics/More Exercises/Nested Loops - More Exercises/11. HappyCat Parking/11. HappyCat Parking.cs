using System;

namespace multiply_table
{
    class Program
    {
        static void Main()
        {

            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double pricefinal = 0;
            for (int i = 1; i <= days; i++)
            {
                double price = 0;
                for (int x = 1; x <= hours; x++)
                {

                    if (i % 2 == 0 && x % 2 != 0)
                    {
                        price += 2.50;
                    }
                    else if (i % 2 != 0 && x % 2 == 0)
                    {
                        price += 1.25;
                    }
                    else
                    {
                        price += 1;
                    }
                }
                pricefinal += price;
                Console.WriteLine($"Day: {i} - {price:f2} leva");
            }
            Console.WriteLine($"Total: {pricefinal:f2} leva");




        }
    }
}