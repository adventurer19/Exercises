using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shopping_Spree;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }
        public string Name
        {
            get => name;
            private set
            {
                Validation.Valid(value,"Name cannot be empty");
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                Validation.ValidAge(value,"Money cannot be negative");
                money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.products.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            if (this.products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            return $"{this.Name} - {string.Join(", ", this.products.Select(p => p.Name))}";

        }
    }
}
