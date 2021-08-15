using System;
namespace Football_Team_Generatorn
{
    public class Player
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                IsValid(value, nameof(Endurance));
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                IsValid(value, nameof(Sprint));
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                IsValid(value, nameof(Dribble));
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                IsValid(value, nameof(Passing));
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                IsValid(value, nameof(Shooting));
                this.shooting = value;
            }
        }

        public int Average
        {

            get => AverageValue();
        }

        private int AverageValue()
        {
            return (int)Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);
        }

        private static void IsValid(int value, string name)
        {
            if (value <= MinValue || value >= MaxValue)
            {
                throw new ArgumentException($"{name} should be between {MinValue} and {MaxValue}.");
            }
        }
    }
}
