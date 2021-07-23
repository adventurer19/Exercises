using System;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            int numberInputCounter = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 1; i <= numberInputCounter; i++)
            {


                int digits = 0;
                int number = i;
                // number = i;
                while (number > 0)
                {
                    digits += number % 10;
                    number /= 10;
                }
                flag = (digits == 5) || (digits == 7) || (digits == 11);
                Console.WriteLine("{0} -> {1}", i, flag);



            }




        }
    }
}