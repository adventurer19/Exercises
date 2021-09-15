using System.Text;

namespace SkiRental
{
    public class Ski
    {
        public string Manufacturer { get;private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Ski(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Manufacturer} - {Model} - {Year}");
            return sb.ToString();
        }
    }
}
