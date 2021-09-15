using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        public string Name { get;private set; }
        public string Class { get;private set; }
        public string Rank { get; set ; }
        public string Description { get;  set; }

        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
            Rank = "Trial";
            Description = "n/a";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {this.Name}: {this.Class}");
            sb.AppendLine($"Rank: {this.Rank}");
            sb.AppendLine($"Description: {this.Description}");
            return sb.ToString().TrimEnd();
        }
    }
}
