using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            //            Наследените пари – реално число в интервала[1.00... 1 000 000.00]
            //Годината, до която трябва да живее(включително) – цяло число в интервала[1801... 1900]
            double money = double.Parse(Console.ReadLine());
            int yearfinal = int.Parse(Console.ReadLine());
            int age = 18;
            double moneyspend = 0;
            double moneyspend1 = 0;
            //int year2 =Math.Abs(1800 - yearfinal);
            for (int i = 1800; i <= yearfinal; i++)
            {
                if (i % 2 == 0)
                {
                    moneyspend += 12000;

                }
                if (i % 2 != 0)
                {

                    age++;
                    moneyspend1 += 12000 + 50 * age++;
                }
            }
            double totalmoney = moneyspend + moneyspend1;
            double x = Math.Abs(money - totalmoney);
            if (totalmoney <= money)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {x:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {x:f2} dollars to survive.");
            }


        }

    }

}