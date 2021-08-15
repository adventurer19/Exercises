using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();
            try
            {
                people = readPeople();
                products = ReadProducts();
            }
            catch (ArgumentException e)
            {
                 Console.WriteLine(e.Message);
                 return;
              
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END") break;
                var items = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var personName = items[0];
                var productName = items[1];
                var person = people[personName];
                var product = products[productName];
                try
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                    
                }
              

            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
            
        }
        

        private static Dictionary<string,Product> ReadProducts()
        {
            var result = new Dictionary<string, Product>();
            var parts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                var productData = part.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var productName = productData[0];
                var cost = decimal.Parse(productData[1]);
                result[productName] = new Product(productName, cost);
            }
            return result;
        }

        private static Dictionary<string,Person> readPeople()
        {
            var result = new Dictionary<string, Person>();
            var parts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in parts)
            {
                var personData = item.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var name = personData[0];
                var money = decimal.Parse(personData[1]);
                result[name] = new Person(name, money);
            }

            return result;
        }
    }
}
