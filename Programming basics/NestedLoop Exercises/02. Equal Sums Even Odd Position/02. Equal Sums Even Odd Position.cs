using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());


            for (int i = n; i <= n1; i++)
            {
                int curr = i;
                int evensum = 0;
                int oddsum = 0;
                int count = 0;
                while (curr != 0)
                {

                    int digit = curr % 10;
                    if (count % 2 == 0)
                    {
                        evensum += digit;
                    }
                    else
                    {
                        oddsum += digit;
                    }
                    curr /= 10;
                    count++;
                }
                if (evensum == oddsum)
                {
                    Console.Write(i + " ");
                }


            }







        }

    }
}