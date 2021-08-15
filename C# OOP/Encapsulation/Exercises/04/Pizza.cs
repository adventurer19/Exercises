using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> topping;

        public Pizza(string name, Dough dought)
        {
            this.Name = name;
            this.Dough = dought;
            this.topping = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough
        {
            get => dough;
            private set
            {
                dough = value;
            }
        }

        public string Calories
        {
            get => TotalCalories();
        }


        public void Add(Topping topping)
        {
            if (this.topping.Count > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            this.topping.Add(topping);
        }

        private string TotalCalories()
        {
            double allCalories = 0;
            foreach (var item in topping)
            {
                allCalories += item.Calories;
            }

            allCalories +=this.dough.Calories;
            return $"{allCalories:f2}";
        }
    }

}