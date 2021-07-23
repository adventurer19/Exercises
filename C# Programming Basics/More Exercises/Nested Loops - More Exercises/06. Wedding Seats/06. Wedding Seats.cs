using System;

namespace nestedloop
{
    class Program
    {
        static void Main(string[] args)
        {
            string end = Console.ReadLine();

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int x = Convert.ToChar(end);
            int e = num2 + 2;
            int counter = 0;
            for (int i = 65; i <= x; i++)
            {

                for (int y = 1; y <= num1; y++)
                {

                    if (y % 2 != 0)
                    {
                        for (int k = 97; k < 97 + num2; k++)
                        {

                            Console.WriteLine($"{Convert.ToChar(i)}{y}{Convert.ToChar(k)}");
                            counter++;
                        }
                    }
                    else if (y % 2 == 0)
                    {
                        for (int k = 97; k < 97 + num2 + 2; k++)
                        {
                            Console.WriteLine($"{Convert.ToChar(i)}{y}{Convert.ToChar(k)}");
                            counter++;
                        }
                    }


                }
                num1++;
            }
            Console.WriteLine(counter);

        }
    }
}