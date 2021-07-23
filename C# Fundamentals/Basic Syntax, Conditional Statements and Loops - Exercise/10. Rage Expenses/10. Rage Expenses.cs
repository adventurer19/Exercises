using System;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int lostGames = int.Parse(Console.ReadLine());
        double headPhonesPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());
        int headPhones = 0;
        int mouse = 0;
        int keyboard = 0;
        int monitor = 0;
        for (int i = 1; i <= lostGames; i++)
        {
            if (i % 2 == 0)
            {
                headPhones++;
            }
            if (i % 3 == 0)
            {
                mouse++;
            }
            if (i % 6 == 0)
            {
                keyboard++;

            }
            if (i % 12 == 0)
            {
                monitor++;
            }

        }
        double totalSum = headPhones * headPhonesPrice + mouse * mousePrice + keyboard * keyboardPrice + monitor * displayPrice;
        Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");

    }
}