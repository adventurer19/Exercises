using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza_Calories
{
    public class Dough
    {
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        string[] typesOfDough = {"Wholegrain","White"};
        string[] typeOfTechnique = {"Crispy", "Chewy", "Homemade"};
           
        
         private const int Mod = 2;
        private string flourType;
        private string bakingTechnique;
        private int weight;
        public string FlourType
        {
            get => flourType;
            private set
            {

                if (!typesOfDough.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }

        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {

                if (!typeOfTechnique.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }

        }

        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }

        public double Calories
        {
            get => TotalCalories();
        }

    

        private double TotalCalories()
        {
            double firstMod = 0;
            switch (flourType)
            {
                case "White":
                    firstMod = 1.5;
                    break;
                    case "Wholegrain":
                        firstMod = 1.0;
                        break;
            }

            double secondMod = 0;
            switch (bakingTechnique)
            {
                case "Crispy":
                    secondMod = 0.9;
                    break;
                case "Chewy":
                    secondMod = 1.1;
                    break;
                case "Homemade":
                    secondMod = 1.0;
                    break;

            }

            return (Mod * weight) * firstMod * secondMod;

        }



    }
}
