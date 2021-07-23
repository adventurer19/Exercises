using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double twice = 0;

            double sumOfGrades = 0;
            double average = 0;
            int n = 0;
            while (n != 12)
            {

                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    twice += 1;


                }
                if (twice >= 2)
                {
                    Console.WriteLine($"{input} has been excluded at {n} grade");
                    break;
                }
                sumOfGrades += grade;
                n += 1;
                average = sumOfGrades / n;

            }
            if (n == 12)
            {
                Console.WriteLine($"{input} graduated. Average grade: {average:f2}");
            }




        }

    }
}
