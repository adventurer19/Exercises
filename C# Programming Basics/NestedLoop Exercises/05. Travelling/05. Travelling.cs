using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            string destination = Console.ReadLine();
            double saved = 0;

            while (destination != "End")
            {

                double SumReq = double.Parse(Console.ReadLine());
                while (SumReq > saved)
                {
                    saved += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");
                saved = 0;
                destination = Console.ReadLine();

            }




        }

    }
}