using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;
        private string name;
        private int age;
        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }

        }
        
        public int Age
        {
            get =>this.age;
            
            private set
            {
                if (value < MinAge || value > MaxAge)
                {
                    throw new ArgumentException($"Age should be between {MinAge} and {MaxAge}.");

                }
                age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                double value = 0.75;
                if (this.age >= 0 && this.age <= 3)
                {
                    value = 1.5;
                }
                else if (this.age >= 4 && this.age <= 7)
                {
                    value = 2;
                }
                else if (this.age >= 8 && this.age <= 11)
                {
                    value = 1;
                }

                return value;
            }



        }

        public double CalculateProductPerDay()
        {
            double value = 0.75;
            if (this.age >= 0 && this.age <= 3)
            {
                value = 1.5;
            }
            else if (this.age >= 4 && this.age <= 7)
            {
                value = 2;
            }
            else if (this.age >=8 && this.age <=11)
            {
                value = 1;
            }

            return value;
            
        }
    }
}
