using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza_Calories
{
    public class Topping
    {
        string[] allTypeTopings = { "Meat", "Veggies", "Cheese", "Sauce" };
        private const double Modi = 2;
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type
        {
            get => type;
            private set
            {
                if (!allTypeTopings.Contains(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");

                }
                type = value;
            }
        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                }

                weight = value; 
            }
        }

        public double Calories
        {
            get => TotalCalories();
        }

        private double TotalCalories()
        {
            double modification = 0;
            switch (type)
            {
                case "Meat":
                    modification = 1.2;
                    break;
                case "Veggies":
                    modification = 0.8;
                    break;
                case "Cheese":
                    modification = 1.1;
                    break;
                case "Sauce":
                    modification = 0.9;
                    break;
            }

            return Modi * weight * modification;
        }
    }
}
