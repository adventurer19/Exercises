using System;
namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {

            int ageOfLily = int.Parse(Console.ReadLine());
            double WashingMachinePrice = double.Parse(Console.ReadLine());
            double ToyPrice = double.Parse(Console.ReadLine());
            const double moneygiven = 10;
            const int toysgiven = 1;
            int toysNumber = 0;
            double savedmoney = 0;
            double savedMoneyTotal = 0;
            for (int birthdays = 1; birthdays <= ageOfLily; birthdays++)
            {
                if (birthdays % 2 == 0)
                {
                    savedmoney += moneygiven;
                    savedMoneyTotal += savedmoney - 1;

                }
                else if (birthdays % 2 != 0)
                {
                    toysNumber += toysgiven;

                }

            }
            double sum = (toysNumber * ToyPrice) + savedMoneyTotal;
            if (sum >= WashingMachinePrice)
            {
                double diff = sum - WashingMachinePrice;
                Console.WriteLine($"Yes! {diff:f2}");

            }
            else
            {
                double diff = sum - WashingMachinePrice;
                Console.WriteLine($"No! {Math.Abs(diff):f2}");
            }
        }

    }


}