using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.allMammals
{
    public abstract class Feline:Mammal
    {
        public string Bread { get; protected set; }
        protected Feline(string name, double weight, string livingRegion,string bread) : base(name, weight, livingRegion)
        {
            this.Bread = bread;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Bread}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
