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
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            int fans1 = 0;
            int fans2 = 0;
            int fans3 = 0;
            int fans4 = 0;
            int totalfans = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= fans; i++)
            {
                string text = Console.ReadLine();
                switch (text)
                {
                    case "A":
                        fans1 += 1;
                        break;

                    case "B":
                        fans2 += 1;
                        break;
                    case "V":
                        fans3 += 1;
                        break;

                    case "G":
                        fans4 += 1;
                        break;

                }

            }
            totalfans = fans1 + fans2 + fans3 + fans4;
            p1 = (1.0 * fans1 / totalfans) * 100;
            p2 = (1.0 * fans2 / totalfans) * 100;
            p3 = (1.0 * fans3 / totalfans) * 100;
            p4 = (1.0 * fans4 / totalfans) * 100;
            p5 = (1.0 * totalfans / capacity) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }

    }

}
