using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Beast!") break;
                var info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = info[0];
                var age = int.Parse(info[1]);
                var gender = info[2];
                if (string.IsNullOrEmpty(name) || age < 0 || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (line == "Cat")
                {
                    var cat = new Cat(name, age, gender);
                    Console.WriteLine(cat);
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (line == "Dog")
                {
                    var Dog = new Dog(name, age, gender);
                    Console.WriteLine(Dog);
                    Console.WriteLine(Dog.ProduceSound());
                }
                else if (line == "Frog")
                {
                    var Frog = new Frog(name, age, gender);
                    Console.WriteLine(Frog);
                    Console.WriteLine(Frog.ProduceSound());
                }
                else if (line == "Kitten")
                {
                    var Kitten = new Kitten(name, age);
                    Console.WriteLine(Kitten);
                    Console.WriteLine(Kitten.ProduceSound());
                }
                else if (line == "Tomcat")
                {
                    var Tomcat = new Tomcat(name, age);
                    Console.WriteLine(Tomcat);
                    Console.WriteLine(Tomcat.ProduceSound());
                }
               
            }
        }
    }
}
