using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace example
{
    class Program
    {
        static void Main()
        {
            List<Person> allPeople = new List<Person>();
            List<Product> allProducts = new List<Product>();
            string[] one = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < one.Length; i += 2)
            {

                string name = one[i];
                if (allPeople.Find(x => x.Name == name) == null)
                {
                    allPeople.Add(new Person()
                    {
                        Name = name,
                        Money = double.Parse(one[i + 1])

                    });
                }


            }
            string[] two = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < two.Length; i += 2)
            {
                string name = two[i];
                if (allProducts.Find(x => x.Name == name) == null)
                {
                    allProducts.Add(new Product()
                    {
                        Name = name,
                        Cost = double.Parse(two[i + 1])

                    });
                }

            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string personName = parts[0];
                string productName = parts[1];
                var person = allPeople.Find(x => x.Name == personName);
                var product = allProducts.Find(x => x.Name == productName);
                if (person.Money >= product.Cost)
                {
                    person.Money -= product.Cost;
                    person.Products.Add(productName);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                input = Console.ReadLine();

            }

            foreach (var idx in allPeople)
            {
                Console.WriteLine(idx);
            }
        }

    }

    class Product
    {

        public string Name { get; set; }
        public double Cost { get; set; }
    }
    class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }

        public List<string> Products { get; set; }
        public Person()
        {
            Products = new List<string>();
        }

        public override string ToString()
        {
            if (Products.Count <= 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {string.Join(", ", Products)}";

            }

        }
    }







}