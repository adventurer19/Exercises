using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
   public class Clinic
    {
        private readonly List<Pet> data;

        public int Count { get => data.Count; }
        public int Capacity {get;private set; }

        public Clinic(int capacity)
        {
            this.data = new List<Pet>();
            this.Capacity = capacity;
        }
        

        public void Add(Pet pet)
        {
                
            if(Count<Capacity) data.Add(pet);
            
        }
        public bool Remove(string pet)
        {

           return  data.Remove(data.FirstOrDefault(x => x.Name == pet));
           
        }

        public Pet GetPet(string name,string owner)
        {
            return data.FirstOrDefault(x => x.Name == name && x.Owner==owner);

        }
        public  Pet GetOldestPet()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();

        }
        public string GetStatistics()
        {
            var sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var item in data)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            return sb.ToString().TrimEnd();

        }



    }
}
