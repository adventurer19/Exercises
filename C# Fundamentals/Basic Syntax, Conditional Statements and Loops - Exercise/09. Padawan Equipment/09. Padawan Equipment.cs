using System;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int countOfStudent = int.Parse(Console.ReadLine());
        double priceOfLightSaber = double.Parse(Console.ReadLine());
        double priceOfRobes = double.Parse(Console.ReadLine());
        double priceOfBelts = double.Parse(Console.ReadLine());

        int allBelts = countOfStudent - countOfStudent / 6;

        int saberneeded = (int)Math.Ceiling(countOfStudent * 1.1);
        double allSabersPrice = saberneeded * priceOfLightSaber;
        double robes = priceOfRobes * countOfStudent;
        double beltCost = allBelts * priceOfBelts;
        double total = beltCost + robes + allSabersPrice;
        if (amountOfMoney >= total)
        {
            Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {Math.Abs(total - amountOfMoney):f2}lv more.");
        }

    }
}