using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public  abstract class Animal
    {
        public string Name { get;private set; }

        public double Weight { get;protected set; }

        public int FoodEaten { get; protected set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public abstract void Roar();
        public abstract void Eat(Food item);

    }
}
