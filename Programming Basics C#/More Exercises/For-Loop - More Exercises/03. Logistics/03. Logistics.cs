using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {

            //            ⦁	До 3 тона – микробус(200 лева на тон)
            //⦁	От 4 до 11 тона – камион(175 лева на тон)
            //⦁	12 и повече тона – влак(120 лева на тон)
            //int kamion = 4000,110000;
            //int microbus = 3000;
            //int vlka =12 000 +;
            int numloading = int.Parse(Console.ReadLine());
            double money = 0;
            int weight1 = 0;
            int weight2 = 0;
            int weight3 = 0;
            for (int i = 1; i <= numloading; i++)
            {
                int loadingtype = int.Parse(Console.ReadLine());
                if (loadingtype <= 3)
                {
                    weight1 += loadingtype;
                    money += loadingtype * 200;
                }
                else if (loadingtype >= 4 && loadingtype <= 11)
                {
                    weight2 += loadingtype;

                    money += loadingtype * 175;

                }
                else if (loadingtype >= 12)
                {
                    weight3 += loadingtype;

                    money += loadingtype * 120;
                }

            }

            int totalweight = weight1 + weight2 + weight3;
            double middle = money / totalweight;
            double p1 = 1.0 * weight1 / totalweight * 100;
            double p2 = 1.0 * weight2 / totalweight * 100;
            double p3 = 1.0 * weight3 / totalweight * 100;

            Console.WriteLine($"{middle:f2}");
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");


        }

    }

}