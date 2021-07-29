using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee:HotBeverage
    {
        private const double Milliliters = 50;
        private const decimal Price = 3.50m;
        public double  Caffeine  { get; set; }

        public Coffee(string name,double Caffeine) : base(name, Price, Milliliters)
        {
            this.Caffeine = Caffeine;
        }

        
    }
}
