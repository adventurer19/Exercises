using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck:Vehicles
    {
        private const double AirCond = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Refueling(double liters)
        {
            this.FuelQuantity += 0.95 * liters;
        }

        public override double AirCondition()
        {
            return AirCond;
        }
    }
}
