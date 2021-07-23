using System;



namespace _17._03
{
    class Program1
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            for (int i = 1; i <= days; i++)
            {
                int patientNumbers = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreated > treated)
                {
                    doctors += 1;
                }
                if (patientNumbers <= doctors)
                {
                    if (patientNumbers == doctors)
                    {
                        treated += doctors;
                    }
                    else
                    {
                        treated += patientNumbers * 1;
                    }
                }
                else if (patientNumbers > doctors)
                {
                    untreated += patientNumbers - doctors;
                    treated += doctors;

                }

            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }


    }

}