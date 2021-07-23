using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyTrip = double.Parse(Console.ReadLine());
            double avaiableMoney = double.Parse(Console.ReadLine());
            double savedMoney = avaiableMoney;
            int counter = 0;
            int counter2 = 0;
            while (counter2 != 5)
            {
                string action = Console.ReadLine();
                double spendOrSaved = double.Parse(Console.ReadLine());
                counter++;

                if (action == "save")
                {

                    savedMoney += spendOrSaved;
                    counter2 = 0;
                }
                else if (action == "spend")
                {
                    counter2++;
                    if (spendOrSaved > savedMoney)
                    {
                        savedMoney = 0;
                    }
                    else
                    {
                        savedMoney = savedMoney - spendOrSaved;
                    }

                }
                if (savedMoney >= moneyTrip)
                {
                    Console.WriteLine($"You saved the money for {counter} days.");
                    return;
                }
            }
            Console.WriteLine($"You can't save the money.");
            Console.WriteLine($"{counter}");

        }
    }
}