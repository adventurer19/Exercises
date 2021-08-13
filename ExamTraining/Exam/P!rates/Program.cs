using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    public class City
    {
        public string Name { get; set; }

        public int Population { get; set; }
        public int Gold { get; set; }

        public City(string name, int population, int gold)
        {
            Name = name;
            Population = population;
            Gold = gold;
        }

        public override string ToString()
        {
            return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listOfCities = new List<City>();
            string line = String.Empty;
            while ((line=Console.ReadLine())!="Sail")
            {
                var cmd = line.Split("||").ToArray();
                var name = cmd[0];
                var population = int.Parse(cmd[1]);
                var gold = int.Parse(cmd[2]);
                if (listOfCities.Find(x => x.Name == name) == null)
                {
                    listOfCities.Add(new City(name,population,gold));
                }
                else
                {
                    var currentCity = listOfCities.First(x => x.Name == name);
                    currentCity.Population += population;
                    currentCity.Gold += gold;

                }
            }
            string lineTwo = String.Empty;
            while ((lineTwo=Console.ReadLine())!="End")
            {
                var cmd = lineTwo.Split("=>").ToArray();
                switch (cmd[0])
                {
                    case "Plunder":
                        var city = cmd[1];
                        var killedPeople = int.Parse(cmd[2]);
                        var stolenGold = int.Parse(cmd[3]);
                        var targetCity = listOfCities.First(x => x.Name == city);
                        if (targetCity != null)
                        {
                            targetCity.Population -= killedPeople;
                            targetCity.Gold -= stolenGold;
                            Console.WriteLine($"{city} plundered! {stolenGold} gold stolen, {killedPeople} citizens killed.");
                        }
                        if (targetCity.Gold <= 0 || targetCity.Population <= 0)
                        {
                            Console.WriteLine($"{targetCity.Name} has been wiped off the map!");
                            listOfCities.Remove(targetCity);
                        }
                        break;

                    case "Prosper":
                        var cityName = cmd[1];
                        var goldIncreased = int.Parse(cmd[2]);
                        var currentCity = listOfCities.Find(x => x.Name == cityName);
                        if (goldIncreased < 0)
                        {
                            Console.WriteLine($"Gold added cannot be a negative number!");
                            continue;
                        }

                        if (currentCity != null)
                        {
                            currentCity.Gold += goldIncreased;
                            Console.WriteLine($"{goldIncreased} gold added to the city treasury. {cityName} now has {currentCity.Gold} gold.");
                        }

                        break;
                }
            }

            Console.WriteLine(listOfCities.Count>0 ? $"Ahoy, Captain! There are {listOfCities.Count} wealthy settlements to go to:" :
                "Ahoy, Captain! All targets have been plundered and destroyed!"
                );
            listOfCities.OrderByDescending(x=>x.Gold).ThenBy(x=>x.Name).ToList().ForEach(x=>Console.WriteLine(x));



        }
    }
}
