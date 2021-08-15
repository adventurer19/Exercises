using System;
using System.Collections.Generic;
using System.Text;
using Shopping_Spree;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public string Name
        {
            get => name;
            private set
            {
                Validation.Valid(value, "Name cannot be empty");
                name = value;
            }
        }

        public decimal Cost
        {
            get => cost;
            private set
            {
                Validation.ValidAge(value, "Money cannot be negative");
                cost = value;
            }
        }

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
