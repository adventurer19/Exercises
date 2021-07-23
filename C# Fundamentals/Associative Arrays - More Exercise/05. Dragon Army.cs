using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {

        static void Main(string[] args)
        {
            var magicalBook = new Dictionary<string, List<Dragon>>();
            int number = int.Parse(Console.ReadLine());
            double life = 250;
            double attack = 45;
            double toughtness = 10;
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                //{type} {name} {damage} {health} {armor}. 
                string type = input[0];
                string name = input[1];
                double damage = GetAValue(input[2], attack);
                double health = GetAValue(input[3], life);
                double armor = GetAValue(input[4], toughtness);
                //Dragon dragonCurrent = new Dragon(name, damage, health, armor);

                if (!magicalBook.ContainsKey(type))
                {
                    magicalBook.Add(type, new List<Dragon>());
                    //magicalBook[type].Add(dragonCurrent);
                }
                var dragonCurrent = magicalBook[type].Find(x => x.Name == name);
                if (dragonCurrent == null)
                {
                    dragonCurrent = new Dragon(name, damage, health, armor);
                    magicalBook[type].Add(dragonCurrent);
                }
                else
                {
                    dragonCurrent.Damage = damage;
                    dragonCurrent.Healt = health;
                    dragonCurrent.Armor = armor;

                }
            }

            foreach (var idx in magicalBook)
            {
                double averageDamage = idx.Value.Average(x => x.Damage);
                double averageHealth = idx.Value.Average(x => x.Healt);
                double averageArmor = idx.Value.Average(x => x.Armor);
                Console.WriteLine($"{idx.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var kvp in idx.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{kvp}");
                }
            }

        }

        private static double GetAValue(string input, double damage)
        {
            double value = damage;
            if (input == "null")
            {
                return damage;
            }
            else
            {
                damage = double.Parse(input);
                return damage;
            }

        }
        class Dragon
        {
            public string Name { get; set; }
            public double Damage { get; set; }
            public double Healt { get; set; }
            public double Armor { get; set; }

            public Dragon(string name, double damage, double healt, double armor)
            {
                Name = name;
                Damage = damage;
                Healt = healt;
                Armor = armor;
            }

            public Dragon()
            {

            }

            public override string ToString()
            {
                return $"-{Name} -> damage: {Damage}, health: {Healt}, armor: {Armor}";
            }
        }
    }
}