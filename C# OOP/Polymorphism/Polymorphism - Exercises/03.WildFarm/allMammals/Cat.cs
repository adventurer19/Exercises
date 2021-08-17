using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.allMammals
{
    public class Cat:Feline
    {
        private const double WEIGHT = 0.30;
        public Cat(string name, double weight, string livingRegion, string bread) : base(name, weight, livingRegion, bread)
        {
        }


        public override void Roar()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food item)
        {
            bool validFood = item is Meat || item is Vegetable;
            if (validFood)
            {
                FoodEaten += item.Quantity;

                Weight += item.Quantity * WEIGHT;
            }
            else
            {
                Console.WriteLine($"{nameof(Cat)} does not eat {item.GetType().Name}!");
            }
        }

        
    }
}
