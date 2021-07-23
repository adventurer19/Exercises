using System;



namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {


            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += int.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }
    }
}