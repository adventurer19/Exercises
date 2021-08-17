using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.allMammals
{
    public class Mouse :Mammal
    {
        private const double WEIGHT = 0.10;
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }


        public override void Roar()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(Food item)
        {
            bool validFood = item is Vegetable || item is Fruit;
            if (validFood)
            {
                FoodEaten += item.Quantity;

                Weight += item.Quantity * WEIGHT;
            }
            else
            {
                Console.WriteLine($"{nameof(Mouse)} does not eat {item.GetType().Name}!");
            }
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }



    }
}
