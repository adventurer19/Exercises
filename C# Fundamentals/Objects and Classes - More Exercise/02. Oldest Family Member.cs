using System;
using System.Collections.Generic;
using System.Linq;

namespace example
{
    class Program
    {
        static void Main()
        {

            int numCount = int.Parse(Console.ReadLine());
            Family familyCurrent = new Family();
            for (int i = 0; i < numCount; i++)
            {
                string[] parts = Console.ReadLine().Split().ToArray();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                var person = new Person(name, age);
                familyCurrent.AddPeople(person);
            }

            Console.WriteLine(familyCurrent.getOld);
        }

    }

    class Family
    {
        private List<Person> OrderPersons { get; set; }
        public Family()
        {
            OrderPersons = new List<Person>();
        }

        public Person getOld => OldPerson();
        public void AddPeople(Person member)
        {
            OrderPersons.Add(member);

        }
        public Person OldPerson()
        {
            Person oldestMember = this.OrderPersons.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestMember;

        }




    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

    }


}