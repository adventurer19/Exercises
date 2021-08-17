using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl:Bird
    {

        private const double WEIGHT = 0.25;

        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override void Roar()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eat(Food item)
        {
            bool validFood = item is Meat;
            if (validFood)
            {
                FoodEaten += item.Quantity;
                Weight += item.Quantity * WEIGHT;
            }
            else
            {
                Console.WriteLine($"{nameof(Owl)} does not eat {item.GetType().Name}!");
            }
        }


      
    }
}
