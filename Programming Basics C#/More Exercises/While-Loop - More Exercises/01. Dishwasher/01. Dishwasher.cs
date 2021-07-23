using System;

namespace  Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Гошо работи в ресторант и отговаря за зареждането на съдомиялната накрая на деня.
            //Вашата задача е да напишете програма, която изчислява,
            //
            //дали дадено закупено количество бутилки от препарат за съдомиялна е достатъчно,
            //за да измие определено количество съдове. Знае се,
            //че всяка бутилка съдържа 750 мл.препарат, за 1 чиния са нужни 5 мл., а за тенджера 15 мл.Приемете,
            //че на всяко трето зареждане със съдове, съдомиялната се пълни само с тенджери, а останалите пъти с чинии.
            //Докато не получите команда "End" ще продължите да получавате бройка съдове, които трябва да бъдат измити.
            int botles = int.Parse(Console.ReadLine());
            int liquid = botles * 750;
            int usedliquid = 0;
            int dish = 0;
            int pots = 0;
            int counter = 0;
            string text = Console.ReadLine();
            while (text != "End")
            {
                counter++;

                int x = int.Parse(text);

                if (counter % 3 == 0)
                {
                    usedliquid += x * 15;
                    dish += x;

                }
                else
                {
                    usedliquid += x * 5;
                    pots += x;
                }


                if (liquid < usedliquid)
                {
                    Console.WriteLine($"Not enough detergent, {usedliquid - liquid} ml. more necessary!");
                    return;

                }
                text = Console.ReadLine();

            }

            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{pots} dishes and {dish} pots were washed.");
            Console.WriteLine($"Leftover detergent {liquid - usedliquid} ml.");

        }
    }
}
