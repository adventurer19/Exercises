using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            double gradetotal = 0;
            int counter = 0;
            while (nameOfPresentation != "Finish")
            {

                double grade = 0;
                double average = 0;
                for (int x = 1; x <= num; x++)
                {
                    counter++;
                    grade += double.Parse(Console.ReadLine());
                    average = grade / num;


                }
                gradetotal += grade;
                Console.WriteLine($"{nameOfPresentation} - {average:f2}.");
                nameOfPresentation = Console.ReadLine();


            }
            double averagegrade = gradetotal / counter;
            Console.WriteLine($"Student's final assessment is {averagegrade:f2}.");
        }
    }
}