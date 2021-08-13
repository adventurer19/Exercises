using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        private int hp;
        private int mp;
        public string Name { get; set; }
        public int HP
        {
            get => hp;
            set
            {
                if (value > 100)
                {
                    hp = 100;
                }
                else
                {
                    hp = value;
                }
            }
        }

        public int MP
        {
            get => mp;
            set
            {
                if (value > 200)
                {
                    mp = 200;
                }
                else
                {
                    mp = value;
                }
            }
        }

        public Hero(string name,int hp, int mp)
        {
            Name = name;    
            this.HP = hp;
            this.MP = mp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine($"  HP: {hp}");
            sb.AppendLine($"  MP: {mp}");
            return sb.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            var heroList = new List<Hero>();
            var countHeroes = int.Parse(Console.ReadLine());
            for (int i = 0; i < countHeroes; i++)
            {
                var cmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = cmd[0];
                var hp = int.Parse(cmd[1]);
                var mp = int.Parse(cmd[2]);
                heroList.Add(new Hero(name, hp, mp));
            }

            var line = string.Empty;
            while ((line=Console.ReadLine())!="End")
            {
                var cmd = line.Split(" - ").ToArray();
                var name = cmd[1];
                var hero = heroList.Find(x => x.Name == name);
                switch (cmd[0])
                {
                    case "CastSpell":
                        var manaNeeed = int.Parse(cmd[2]);
                        var spellName = cmd[3];
                        if (hero != null)
                        {
                            if (hero.MP >= manaNeeed)
                            {
                                hero.MP -= manaNeeed;
                                Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.MP} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
                            }

                        }
                        break;
                    case "TakeDamage":
                        var dmg = int.Parse(cmd[2]);
                        var attacker = cmd[3];
                        if (hero != null)
                        {
                            if (hero.HP > dmg)
                            {
                                hero.HP -= dmg;
                                Console.WriteLine($"{hero.Name} was hit for {dmg} HP by {attacker} and now has {hero.HP} HP left!");
                            }
                            else
                            {
                                Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                                heroList.Remove(hero);
                            }
                        }
                        break;
                    case "Recharge":
                        if (hero != null)
                        {
                            int amount = int.Parse(cmd[2]);
                            int recharged = 0;
                            if (hero.MP + amount <= 200)
                            {
                                recharged = amount;
                            }
                            else
                            {
                                recharged = 200 - hero.MP;
                            }

                            hero.MP += amount;
                            Console.WriteLine($"{hero.Name} recharged for {recharged} MP!");
                        }

                        break;
                    case "Heal":
                        if (hero != null)
                        {
                            int amount = int.Parse(cmd[2]);
                            int healed = 0;
                            if (hero.HP + amount <= 100)
                            {
                                healed = amount;
                            }
                            else
                            {
                                healed = 100 - hero.HP;
                            }

                            hero.HP += amount;
                            Console.WriteLine($"{hero.Name} healed for {healed} HP!");
                        }
                        break;
                }
            }

            heroList = heroList.OrderByDescending(x => x.HP).ThenBy(x => x.Name).ToList();
            foreach (var hero in heroList)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.HP}");
                Console.WriteLine($"  MP: {hero.MP}");
            }

        }
    }
}
