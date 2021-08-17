using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.allMammals
{
    public class Dog:Mammal
    {
        private const double WEIGHT = 0.40;

        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        public override void Roar()
        {
            Console.WriteLine("Woof!");
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
                Console.WriteLine($"{nameof(Dog)} does not eat {item.GetType().Name}!");
            }
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
            //Mice and Dogs – "{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]"


    }
}
