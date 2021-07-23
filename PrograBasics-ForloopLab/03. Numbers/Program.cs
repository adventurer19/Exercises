using System;



namespace _17._03
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}