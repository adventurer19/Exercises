using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly List<Car> data;
        public string Type { get; private set; }
        public int Capacity { get; private set; }
        public int Count => data.Count;


        public Parking(string type, int capacity)
        {
            this.data = new List<Car>();
            Type = type;
            Capacity = capacity;
        }

        public void Add(Car car)
        {
            if (Capacity > this.data.Count)
            {
                data.Add(car);;
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            return data.Remove(data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model));
        }

        public Car GetLatestCar()
        {
            return data.OrderByDescending(x => x.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            return data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            for (int i = 0; i < data.Count; i++)
            {
                sb.AppendLine($"{data[i]}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
