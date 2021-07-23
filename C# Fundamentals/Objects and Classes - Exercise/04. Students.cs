using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace Classes
{

    class Program
    {

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                var student = new Student(input[0], input[1], double.Parse(input[2]));
                students.Add(student);


            }

            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var istudent in students)
            {
                Console.WriteLine(istudent);
            }



        }

    }

    class Student
    {
        //  Each student should have a First name(string), a Last name(string) and a grade(a floating-point number). 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article()
        {

        }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}