using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] inputs = input.Split(new string[] { " <:> " }, StringSplitOptions.None);
                string name = inputs[0];
                string color = inputs[1];
                int physics = int.Parse(inputs[2]);

                Dwarf repeat = dwarfs.Find(x => x.Name == name && x.Color == color);
                if (repeat == null)
                {
                    Dwarf dwarf = new Dwarf(name, color, physics);
                    dwarfs.Add(dwarf);
                }
                else
                {
                    repeat.Physics = Math.Max(repeat.Physics, physics);
                }
                input = Console.ReadLine();
            }
            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs.Count(y => y.Color == x.Color)))
            {
                Console.WriteLine("({0}) {1} <-> {2}", dwarf.Color, dwarf.Name, dwarf.Physics);
            }
        }
    }

    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string color, int physics)
        {
            Name = name;
            Color = color;
            Physics = physics;
        }
    }
}