using System.Text;

namespace StreetRacing
{
    //First, write a C# class, called Car with properties:
    //Make: string
    //Model: string
    //LicensePlate: string
    //HorsePower: int
    //Weight: double
    //The constructor of Car class should receive make, model, licensePlate, horsePower and weight.
    //The class should also have the following methods:
    //Override ToString() method in the format:
    //"Make: {Make}
    //Model: {Model}
    //License Plate: { LicensePlate}
    //Horse Power: { HorsePower}
    //Weight: { Weight}
    //"
    public class Car
    {
        public string Make { get;private set; }

        public string Model { get;private set; }

        public string LicensePlate { get;private set; }

        public int HorsePower  { get;private set; }

        public double Weight { get; private set; }

        public Car(string make, string model, string licensePlate, int horsePower, double weight)
        {
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
            HorsePower = horsePower;
            Weight = weight;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"License Plate: {LicensePlate}");
            sb.AppendLine($"Horse Power: {HorsePower}");
            sb.AppendLine($"Weight: {Weight}");
            return sb.ToString();
        }
    }
}
