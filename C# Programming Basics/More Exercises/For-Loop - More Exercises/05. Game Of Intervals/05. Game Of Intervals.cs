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

            int turns = int.Parse(Console.ReadLine());
            double points = 0;

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;

            for (int i = 1; i <= turns; i++)
            {
                int turnscount = int.Parse(Console.ReadLine());
                if (turnscount >= 0 && turnscount <= 50)
                {
                    if (turnscount >= 0 && turnscount <= 9)
                    {
                        num1 += 1;
                        points += turnscount * 0.2;
                    }

                    else if (turnscount >= 10 && turnscount <= 19)
                    {
                        num2 += 1;
                        points += turnscount * 0.3;
                    }
                    else if (turnscount >= 20 && turnscount <= 29)
                    {
                        num3 += 1;
                        points += turnscount * 0.4;

                    }
                    else if (turnscount >= 30 && turnscount <= 39)
                    {
                        num4 += 1;
                        points += 50;

                    }
                    else if (turnscount >= 40 && turnscount <= 50)
                    {
                        num5 += 1;
                        points += 100;

                    }
                    //result = points1 + points2 + points3 + points4 + points5;


                }
                else if (turnscount < 0 || turnscount > 50)
                {
                    num6 += 1;
                    points /= 2;
                }


            }
            int totalnums = num1 + num2 + num3 + num4 + num5 + num6;
            double p1 = 1.0 * num1 / totalnums * 100;
            double p2 = 1.0 * num2 / totalnums * 100;
            double p3 = 1.0 * num3 / totalnums * 100;
            double p4 = 1.0 * num4 / totalnums * 100;
            double p5 = 1.0 * num5 / totalnums * 100;
            double p6 = 1.0 * num6 / totalnums * 100;
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {p1:f2}%");
            Console.WriteLine($"From 10 to 19: {p2:f2}%");
            Console.WriteLine($"From 20 to 29: {p3:f2}%");
            Console.WriteLine($"From 30 to 39: {p4:f2}%");
            Console.WriteLine($"From 40 to 50: {p5:f2}%");
            Console.WriteLine($"Invalid numbers: {p6:f2}%");


        }

    }

}
