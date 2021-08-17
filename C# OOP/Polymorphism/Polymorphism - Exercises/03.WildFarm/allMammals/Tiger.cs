using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.allMammals
{
    public class Tiger:Feline
    {
        private const double WEIGHT = 1;
        public Tiger(string name, double weight, string livingRegion, string bread) : base(name, weight, livingRegion, bread)
        {
        }
        public override void Roar()
        {
            Console.WriteLine("ROAR!!!");
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
                Console.WriteLine($"{nameof(Tiger)} does not eat {item.GetType().Name}!");
            }
        }




    }
}
