using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car:Vehicles
    {

        private const double AirCond = 0.9;


        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Refueling(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override double AirCondition()
        {
            return AirCond;
        }
    }
}
