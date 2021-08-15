using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generatorn
{
    public class Team
    {
        private string name;
        private HashSet<Player> allPlayers;
        public Team(string name)
        {
            this.Name = name;
            this.allPlayers = new HashSet<Player>();
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

                name = value;
            }
        }

       
        public void AddPlayer(Player newPlayer)
        {
            this.allPlayers.Add(newPlayer);
        }

        public void Removed(string name)
        {
            var player = allPlayers.FirstOrDefault(x => x.Name == name);
            if (player  is null)
            {
                throw new InvalidOperationException($"Player {name} is not in {this.Name} team.");

            }
            allPlayers.Remove(player);
            
        }

        public int AvgRating
        {
            get => TeamRating();
        }

        private int TeamRating()
        {
            int value = default;
            foreach (var item in allPlayers)
            {
                value += item.Average;
            }
            if (value == 0)
            {
                return 0;
            }

            return value / allPlayers.Count;
        }

    }
}