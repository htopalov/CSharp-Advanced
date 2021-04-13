using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        private string name;
        private int capacity;

        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public int Count => roster.Count;
        public string Name 
        {
            get => this.name;
            set => this.name = value;
        }

        public int Capacity 
        {
            get => this.capacity;
            set => this.capacity = value;
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            var player = roster.FirstOrDefault(x => x.Name == name);
            if (player != null)
            {
                return roster.Remove(player);
            }
            else
            {
                return false;
            }
        }

        public void PromotePlayer(string name)
        {
            var player = roster.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }

        }

        public void DemotePlayer(string name)
        {
            var player = roster.FirstOrDefault(x => x.Name == name);
            if (player.Rank != "Trial")
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            var players = roster.Where(x => x.Class == @class).ToArray();
            roster.RemoveAll(x => x.Class == @class);
            return players;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
