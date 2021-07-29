using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double Grams = 250;
        private const double Calories = 1000;
        private const decimal Price = 5m;
        public Cake(string name) :
            base(name, Price, Grams, Calories)
        {
        }
    }
}
