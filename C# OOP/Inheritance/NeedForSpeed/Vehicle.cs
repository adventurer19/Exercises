using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        //: int horsePower, double fuel
        private int horsePower;
        private double fuel;
        private const double DefaultFuelConsumption = 1.25;

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public int HorsePower
        {
            get { return horsePower; }
            set { fuel = value; }
        }

        public double Fuel
        {
            get { return fuel; }
           
        }

        public Vehicle(int horsePower, double fuel)
        {
            this.horsePower = horsePower;
            this.fuel = fuel;
        }

        public virtual void Drive(double kms)
        {
            this.fuel -= kms * FuelConsumption;
        }
    }
}
