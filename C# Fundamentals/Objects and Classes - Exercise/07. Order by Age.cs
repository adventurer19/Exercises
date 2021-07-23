using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;


namespace Classes
{
    class ID
    {
        public string Name { get; set; }
        public string IdNum { get; set; }

        public int Age { get; set; }

        public ID(string name, string idNum, int age)
        {
            Name = name;
            IdNum = idNum;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {IdNum} is {Age} years old.";
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<ID> listofIDs = new List<ID>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                string[] token = input.Split(' ').ToArray();
                string name = token[0];
                string id = token[1];
                int age = int.Parse(token[2]);
                ID currentId = new ID(name, id, age);
                listofIDs.Add(currentId);


            }

            foreach (var idxID in listofIDs.OrderBy(x => x.Age))
            {
                Console.WriteLine(idxID);

            }



        }
    }
}