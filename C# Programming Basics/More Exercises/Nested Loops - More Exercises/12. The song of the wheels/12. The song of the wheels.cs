using System;

namespace nestedloop_exercises
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isTrue = false;
            bool isFalse = false;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {

                            if (a < b && c > d && a * b + c * d == input)
                            {
                                isFalse = true;
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    isTrue = true;
                                    num1 = a;
                                    num2 = b;
                                    num3 = c;
                                    num4 = d;
                                }
                            }

                        }


                    }
                }

            }
            if (isFalse) { Console.WriteLine(); }
            if (isTrue) { Console.WriteLine($"Password: {num1}{num2}{num3}{num4}"); }
            else Console.WriteLine($"No!");
            // else if(isTrue)Console.WriteLine($"\nPassword: {num1}{num2}{num3}{num4}");
            //  else Console.WriteLine($"No!");
        }
    }
}