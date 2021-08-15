using System;
using System.Linq;

namespace Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {


            try
            {
                var pizzaInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = String.Empty;
                if (pizzaInfo.Length>1)
                { 
                    name = pizzaInfo[1];

                }
                var DoughtType = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var type = Filtered(DoughtType[1]);
                var tech = Filtered(DoughtType[2]);
                var cal = int.Parse(DoughtType[3]);
                var pizza = new Pizza(name, new Dough(type, tech, cal));
                string line = String.Empty;
                while ((line = Console.ReadLine()) != "END")
                {
                    var cmd = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    cmd[1] = Filtered(cmd[1]);
                    var topping = new Topping(cmd[1], int.Parse(cmd[2]));
                    pizza.Add(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories} Calories.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static string Filtered(string value)
        {
            
            var array = value.ToCharArray();

            array[0] = char.ToUpper(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = char.ToLower(array[i]);
            }
            return new string(array);

        }
    }
}
