using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace traning_2
{
    class Student
    {

        public string FirstName;
        public string LastName;
        public int Age;
        public string HomeTown;

        public Student(string aFirstName, string aLastName, int aAge, string aHomeTown)
        {

            FirstName = aFirstName;
            LastName = aLastName;
            Age = aAge;
            HomeTown = aHomeTown;
        }
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                string[] parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int ages = int.Parse(parts[2]);

                Students.Add(new Student(parts[0], parts[1], ages, parts[3]));

            }

            string home = Console.ReadLine();

            List<Student> filtered = Students.Where(s => s.HomeTown == home).ToList();
            foreach (Student student in filtered)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }



        }

    }
}