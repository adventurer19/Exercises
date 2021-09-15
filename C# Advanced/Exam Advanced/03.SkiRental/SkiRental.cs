using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private readonly List<Ski> data;
        public string Name { get; private set; }
        public int Capacity { get;private set; }
        public int Count => data.Count;

        public SkiRental(string name, int capacity)
        {
            this.data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public void Add(Ski ski)
        {
            if (this.Count < this.Capacity)
            {
                this.data.Add(ski);
            }

        }

        public bool Remove(string manufacturer, string model)
        {
           // var itemToBeRemoved = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
           return data.Remove(data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model));
        }

        public Ski GetNewestSki()
        {
            var itemToBeReturned = data.OrderByDescending(x => x.Year).FirstOrDefault();
            return itemToBeReturned;

        }

        public Ski GetSki(string manufacturer, string model)
        {
            return data.Find(x => x.Manufacturer == manufacturer && x.Model == model);

        }

        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            for (int i = 0; i < data.Count; i++)
            {
                sb.AppendLine($"{data[i]}");
            }
            return sb.ToString();
        }
    }
}
