using System;
using System.Linq;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static string Get() { return Console.ReadLine(); }
        static void Main()
        {
            bool Found = false;
            //"{firstName} {lastName} is {age} years old.".
            List<Student> StudentCurrent = new List<Student>();
            string TownRequires = string.Empty;
            while (true)
            {
                Found = false;
                string input = Get();
                if (input == "end") { TownRequires = Get(); break; }
                else
                {
                    string[] parts = input.Split(' ').ToArray();
                    string FName = parts[0];
                    string LName = parts[1];
                    int Age = Convert.ToInt32(parts[2]);
                    string Town = parts[3];

                    Student stud = StudentCurrent
                        .Find(x => x.FirstName == FName && x.LastName == LName);
                    if (stud == null)
                    {
                        stud = new Student();
                        {
                            stud.FirstName = FName;
                            stud.LastName = LName;
                            stud.age = Age;
                            stud.homeTown = Town;

                        }
                        StudentCurrent.Add(stud);
                    }
                    else
                    {
                        stud.age = Age;
                    }
                    //for (int i = 0; i < StudentCurrent.Count; i++)
                    //{
                    //    if (StudentCurrent[i].FirstName == FName && StudentCurrent[i].LastName == LName && StudentCurrent[i].age < Age) { StudentCurrent[i] = stud; Found = true; break; }


                    //}
                    //if (!Found) { StudentCurrent.Add(stud); Found = false; }
                }

            }

            foreach (Student s in StudentCurrent)
            {
                if (s.homeTown == TownRequires)
                {
                    Console.WriteLine($"{s.FirstName } {s.LastName} is {s.age} years old.");
                }
            }
        }


        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int age { get; set; }
            public string homeTown { get; set; }
        }


    }
}


