using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen:Bird
    {private const double WEIGHT = 0.35;
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Roar()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat(Food item)
        {

            FoodEaten += item.Quantity;
            Weight += item.Quantity * WEIGHT;
            
         
        }


    }
}
