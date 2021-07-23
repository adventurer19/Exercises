using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            int amountNum = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 1; i <= amountNum; i++)
            {
                int Num = int.Parse(Console.ReadLine());
                if (Num < 200)
                {
                    p1++;

                }
                else if (Num < 400)
                {
                    p2++;
                }
                else if (Num < 600)
                {
                    p3++;

                }
                else if (Num < 800)
                {
                    p4++;
                }
                else if (Num < 1000)
                {
                    p5++;
                }
            }
            double procent1 = 1.0 * p1 / amountNum * 100;
            double procent2 = 1.0 * p2 / amountNum * 100;
            double procent3 = 1.0 * p3 / amountNum * 100;
            double procent4 = 1.0 * p4 / amountNum * 100;
            double procent5 = 1.0 * p5 / amountNum * 100;
            Console.WriteLine($"{procent1:f2}%");
            Console.WriteLine($"{procent2:f2}%");
            Console.WriteLine($"{procent3:f2}%");
            Console.WriteLine($"{procent4:f2}%");
            Console.WriteLine($"{procent5:f2}%");
        }
    }

}