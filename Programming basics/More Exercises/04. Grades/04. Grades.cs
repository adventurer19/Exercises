using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {
            //между 2.00 и 2.99, между 3.00 и
            //3.99, между 4.00 и 4.99, 5.00 или повече.
            int students = int.Parse(Console.ReadLine());
            int gradeBelow3 = 0;
            int gradeBelow4 = 0;
            int gradeBelow5 = 0;
            int gradeBelow6 = 0;
            double sum = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade <= 2.99)
                {
                    gradeBelow3 += 1;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    gradeBelow4 += 1;

                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    gradeBelow5 += 1;
                }
                else if (grade >= 5.00)
                {
                    gradeBelow6 += 1;

                }
                sum += grade;

            }
            // double allgrades = gradeBelow3 + gradeBelow4 + gradeBelow5 + gradeBelow6;
            double p1 = 1.0 * gradeBelow6 / students * 100;
            double p2 = 1.0 * gradeBelow5 / students * 100;
            double p3 = 1.0 * gradeBelow4 / students * 100;
            double p4 = 1.0 * gradeBelow3 / students * 100;
            double average = sum / students;
            Console.WriteLine($"Top students: {p1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {p2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {p3:f2}%");
            Console.WriteLine($"Fail: {p4:f2}%");
            Console.WriteLine($"Average: {average:f2}");


        }

    }

}