using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            //            ⦁	От 0 до 9  20 % от числото
            //⦁	От 10 до 19  30 % от числото
            //⦁	От 20 до 29  40 % от числото
            //⦁	От 30 до 39  50 точки
            //⦁	От 40 до 50  100 точки
            //⦁	Невалидно число  резултата се дели на 2
            double water = 0;
            double internet = 0;
            double others = 0;
            double middle = 0;
            double monthse = 0;
            int months = int.Parse(Console.ReadLine());
            for (int i = 1; i <= months; i++)
            {
                double monthpays = double.Parse(Console.ReadLine());
                monthse += monthpays;
                water += 20;
                internet += 15;
                others = (monthse + water + internet) + (monthse + water + internet) * 0.20;
            }

            middle = (monthse + water + internet + others) / months;
            Console.WriteLine($"Electricity: {monthse:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {middle:f2} lv");
        }

    }

}