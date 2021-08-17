using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.allMammals;

namespace WildFarm
{
   public class Program
    {
        static void Main(string[] args)
        {
            string line = String.Empty;
            var animalList = new List<Animal>();
            Animal item = null;
            Food food = null;
            
            int counter = 0;
            while ((line=Console.ReadLine())!="End")
            {
                if (counter % 2 == 0)
                {
                    var cmd = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var name = cmd[1];
                    var weight = double.Parse(cmd[2]);

                    if (cmd[0] == "Cat")
                    {
                        var region = cmd[3];
                        var bread = cmd[4];
                        item = new Cat(name, weight, region, bread);
                    }
                    else if (cmd[0] == "Tiger")
                    {
                        var region = cmd[3];
                        var bread = cmd[4];
                        item = new Tiger(name, weight, region, bread);
                    }
                    else if (cmd[0] == "Dog")
                    {
                        var region = cmd[3];
                        item = new Dog(name, weight, region);

                    }
                    else if (cmd[0] == "Mouse")
                    {
                        var region = cmd[3];
                        item = new Mouse(name, weight, region);
                    }
                    else if (cmd[0] == "Owl")
                    {
                        var wings = double.Parse(cmd[3]);
                        item = new Owl(name, weight, wings);
                    }
                    else if (cmd[0] == "Hen")
                    {
                        var wings = double.Parse(cmd[3]);
                        item = new Hen(name, weight, wings);
                    }
                    else
                    {
                        continue;
                    }
                    item.Roar();
                    animalList.Add(item);
                }
                else
                {
                    var cmd = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var amount = int.Parse(cmd[1]);
                    if (cmd[0] == "Vegetable")
                    {
                        food = new Vegetable(amount);
                    }
                    else if (cmd[0] == "Fruit")
                    {
                        food = new Fruit(amount);
                    }
                    else if (cmd[0] == "Meat")
                    {
                        food = new Meat(amount);

                    }
                    else if (cmd[0] == "Seeds")
                    {
                        food = new Seed(amount);
                        
                    }
                    item.Eat(food);
                    
                }

                counter++;

            }

            animalList.ForEach(x => Console.WriteLine(x));

        }
    }
}
