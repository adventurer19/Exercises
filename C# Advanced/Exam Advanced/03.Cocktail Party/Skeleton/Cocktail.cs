using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private readonly List<Ingredient> Ingredients;
        public string Name { get; private set; }
        public int 	Capacity { get; private set; }
        public int MaxAlcoholLevel { get; private set; }
        public int CurrentAlcoholLevel => this.Ingredients.Sum(x=>x.Alcohol);

     
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
           
            Ingredients = new List<Ingredient>();
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }
        
        public void Add(Ingredient ingredient)
        {
           
            bool check = !Ingredients.Contains(ingredient);
            bool checkAlco = MaxAlcoholLevel >= ingredient.Alcohol;
            if (check && checkAlco)
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            return Ingredients.Remove(Ingredients.FirstOrDefault(x => x.Name == name));

        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(x => x.Name == name);
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            for (int i = 0; i < Ingredients.Count; i++)
            {
                sb.AppendLine($"{Ingredients[i]}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
