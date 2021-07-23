using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int allSum = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int counter = 0;
            int counterNOCard = 0;
            int CounterCard = 0;
            int SumNoCard = 0;
            int SumCard = 0;
            int totalsum = 0;
            while (allSum > totalsum)
            {

                int sum = int.Parse(text);
                counter++;
                //totalsum += sum;
                if (sum >= 10 && counter % 2 == 0)
                {
                    SumCard += sum;
                    totalsum += sum;
                    CounterCard++;
                    Console.WriteLine("Product sold!");

                }
                else if (sum <= 100 && counter % 2 != 0) //cash
                {
                    SumNoCard += sum;
                    totalsum += sum;
                    counterNOCard++;
                    Console.WriteLine("Product sold!");

                }

                else
                {
                    Console.WriteLine("Error in transaction!");
                }
                //totalsum += sum;


                text = Console.ReadLine();
                if (text == "End")
                {
                    Console.WriteLine($"Failed to collect required money for charity.");
                    return;
                }


            }
            if (allSum <= totalsum)
            {
                double averageNOCard = 1.0 * SumNoCard / counterNOCard;
                double averagewithCard = 1.0 * SumCard / CounterCard;
                Console.WriteLine($"Average CS: {averageNOCard:f2}");
                Console.WriteLine($"Average CC: {averagewithCard:f2}");
            }




        }
    }
}
