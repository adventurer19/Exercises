using System;
using System.Linq;
using System.Collections.Generic;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //{hero name} {HP} {MP} 
            int number = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();
            for (int i = 0; i < number; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();
                string name = info[0];
                int hp = int.Parse(info[1]);
                int mp = int.Parse(info[2]);
                if (heroes.Find(x => x.Name == name) == null)
                {
                    heroes.Add(new Hero(name, hp, mp));
                }
            }
            string input = String.Empty;
            while (input != "End")
            {
                input = Console.ReadLine();
                string[] parts = input.Split(" - ").ToArray();
                string command = parts[0];
                //CastSpell – { hero name} – { MP needed} – { spell name}
                if (command == "CastSpell")
                {
                    int manaNeeded = int.Parse(parts[2]);
                    string spellName = parts[3];
                    var hero = heroes.Find(x => x.Name == parts[1]);
                    if (hero.MP >= manaNeeded)
                    {
                        hero.MP -= manaNeeded;
                        Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    //TakeDamage – {hero name} – {damage} – {attacker}
                    int dmg = int.Parse(parts[2]);
                    string attackerName = parts[3];
                    var hero = heroes.Find(x => x.Name == parts[1]);
                    if (hero.HP > dmg)
                    {
                        hero.HP -= dmg;
                        Console.WriteLine($"{hero.Name} was hit for {dmg} HP by {attackerName} and now has {hero.HP} HP left!");
                    }
                    else
                    {

                        Console.WriteLine($"{hero.Name} has been killed by {attackerName}!");
                        heroes.Remove(hero);

                    }

                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(parts[2]);
                    var hero = heroes.Find(x => x.Name == parts[1]);
                    int oldMana = hero.MP;
                    hero.MP += amount;
                    int recoveryAmount = 0;
                    if (hero.MP == 200)
                    {
                        recoveryAmount = hero.MP - oldMana;
                    }
                    else
                    {
                        recoveryAmount = amount;
                    }
                    Console.WriteLine($"{hero.Name} recharged for {recoveryAmount} MP!");
                    //Recharge – {hero name} – {amount}

                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(parts[2]);
                    var hero = heroes.Find(x => x.Name == parts[1]);
                    int oldHP = hero.HP;
                    hero.HP += amount;
                    int recoveryAmount = 0;
                    if (hero.HP == 100)
                    {
                        recoveryAmount = hero.HP - oldHP;
                    }
                    else
                    {
                        recoveryAmount = amount;
                    }

                    Console.WriteLine($"{hero.Name} healed for {recoveryAmount} HP!");
                }
            }

            List<Hero> sorted = heroes.OrderByDescending(x => x.HP).ThenBy(x => x.Name).ToList();
            foreach (var idx in sorted)
            {
                Console.WriteLine($"{idx.Name}");
                Console.WriteLine($"  HP: {idx.HP}");
                Console.WriteLine($"  MP: {idx.MP}");
            }
        }
    }

    class Hero
    {
        public string Name { get; set; }
        private int healt;
        public int HP
        {
            get
            {
                return healt;
            }
            set
            {
                if (value > 100)
                {
                    healt = 100;
                }
                else
                {
                    healt = value;
                }
            }
        }

        private int mana;
        public int MP
        {
            get
            {
                return mana;
            }
            set
            {
                if (value > 200)
                {
                    mana = 200;
                }
                else
                {
                    mana = value;
                }
            }

        }

        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;

        }
    }
}