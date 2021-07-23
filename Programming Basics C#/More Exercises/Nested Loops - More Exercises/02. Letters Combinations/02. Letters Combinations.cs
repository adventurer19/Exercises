using System;
namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            string three = Console.ReadLine();
            int start = Convert.ToChar(one);
            int end = Convert.ToChar(two);
            int missing = Convert.ToChar(three);
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int x = start; x <= end; x++)
                {
                    for (int y = start; y <= end; y++)
                    {
                        if (i == missing || x == missing || y == missing)
                        {
                            continue;
                        }

                        counter++;

                        Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(x)}{Convert.ToChar(y)} ");
                    }
                }
            }

            Console.WriteLine(counter);





        }
    }
}