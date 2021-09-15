using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public class Car
    {
        public string Manufacturer { get;private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Manufacturer} {Model} ({Year})");
            return sb.ToString().TrimEnd();
        }
    }
}
