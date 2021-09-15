using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private readonly List<Player> roster;
        public string Name { get; private set; }
        public int Capacity { get; private set; }

        public int Count => roster.Count;

        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            Name = name;
            Capacity = capacity;
        }
        public void AddPlayer(Player player)
        {

            if (this.Capacity > this.roster.Count)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            return roster.Remove(roster.FirstOrDefault(x => x.Name == name));
        }

        public void PromotePlayer(string name)
        {
            var item = roster.First(x => x.Name == name);
            if (item.Rank != "Member")
            {
                item.Rank = "Member";
            }

        }
        public void DemotePlayer(string name)
        {
            var item = roster.First(x => x.Name == name);
            if (item.Rank != "Trial")
            {
                item.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string aClass)
        {
            var array = roster.Where(x => x.Class == aClass).ToArray();
            roster.RemoveAll(x => x.Class == aClass);
            return array;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in this.roster)
            {
                sb.AppendLine($"Player {player.Name}: {player.Class}");
                sb.AppendLine($"Rank: {player.Rank}");
                sb.AppendLine($"Description: {player.Description}");
            }
            return sb.ToString().TrimEnd();
        }


    }
}
