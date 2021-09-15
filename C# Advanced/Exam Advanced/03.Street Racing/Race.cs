using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    //Next step is to write Race class that has a collection of type Car with corresponding unique License Plate of a Car.
    //The name of the collection should be Participants.All the entities of the Participants collection have the same properties.
    //The Race has also some additional properties:
    //Name: string
    //Type: string
    //Laps: int
    //Capacity: int - the maximum allowed number of participants in the race
    //MaxHorsePower: int - the maximum allowed Horse Power of a Car in the Race
    //The constructor of the Race class should receive name, type, laps, capacity and maxHorsePower.

    //Implement the coming features:
    //Getter Count - returns the count of the currently enrolled participants

    //Method Add(Car car) - adds the entity if there isn't a Car with the same License plate and,
    //if there is enough space in terms of race capacity and if the car meets the maximum horse power requirment of the race.

    //Method Remove(string licensePlate) - removes a Car from the race with the given License plate,
    //if such exists and returns bool if the deletion is successful.

    //Method FindParticipant(string licensePlate) - returns a Car with the given License plate.
    //If it doesn't exist, return null.

    //Method GetMostPowerfulCar() – returns the Car with most HorsePower.
    //If there are no Cars in the Race, method should return null. 

    //Method Report() - returns information about the Race and the Cars participating it in the following format:
    //"Race: {Name} - Type: {Type} (Laps: {Laps})
    //{ Car1}
    //{Car2}
    public class Race
    {
        private readonly List<Car> Participants;
        public string  Name { get; private set; }
        public string  Type { get; private set; }
        public int Laps {  get;private set; }
        public int Capacity { get;private set; }
        public int MaxHorsePower { get;private set; }

        public int Count => Participants.Count;
        

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Participants = new List<Car>();
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

        public void Add(Car Car)
        {
            bool existingPlate = !Participants.Exists(x => x.LicensePlate == Car.LicensePlate);
            bool horsePowerLimit = this.MaxHorsePower >= Car.HorsePower;
            bool haveSpot = Count < this.Capacity;
            if (existingPlate && haveSpot && horsePowerLimit)
            {
                Participants.Add(Car);
            }

        }

        public bool Remove(string licenseInput)
        {
            return Participants.Remove(Participants.Find(x => x.LicensePlate == licenseInput));

        }
        public Car FindParticipant(string licensePlate)
        {
            return Participants.Find(x => x.LicensePlate == licensePlate);

        }
        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(x => x.HorsePower).FirstOrDefault();
        }

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            //sb.AppendLine(string.Join("", Participants)); bonus
            for (int i = 0; i < Participants.Count; i++)
            {
                sb.AppendFormat($"{Participants[i]}");
            }
            return sb.ToString();
            
        }
    }
}
