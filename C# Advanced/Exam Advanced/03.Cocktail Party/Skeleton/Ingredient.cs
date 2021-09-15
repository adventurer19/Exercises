using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        public string Name { get; private set; }
        public int Alcohol { get; private set; }
        public int Quantity { get; private set; }

        public Ingredient(string name, int alcohol, int quantity)
        {
            Name = name;
            Alcohol = alcohol;
            Quantity = quantity;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Ingredient: {Name}");
            sb.AppendLine($"Quantity: {Quantity}");
            sb.AppendLine($"Alcohol: {Alcohol}");
            return sb.ToString().TrimEnd(); 
        }
    }
}
