using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public Guild(string name, int capacity)
        {
            this.roster = new List<Player>();
            this.Name = name;
            this.Capacity = capacity;
        }
        public string Name{ get; set; }
        public int Capacity { get; set; }
        public int Count { get { return roster.Count; } }

        public void AddPlayer(Player player)
        {
            if (roster.Count < Capacity)
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            var currentPlayer = roster.FirstOrDefault(x => x.Name == name);
            if (currentPlayer != null)
            {
                roster.Remove(currentPlayer);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PromotePlayer(string name)
        {
            var promotedPlayer = roster.FirstOrDefault(x => x.Name == name);
            if (promotedPlayer.Rank != "Member")
            {
                promotedPlayer.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            var promotedPlayer = roster.FirstOrDefault(x => x.Name == name);
            if (promotedPlayer.Rank != "Trial")
            {
                promotedPlayer.Rank = "Trial";
            }
        }
        public Player[] KickPlayersByClass(string Class)
        {
            Player[] kickedPlayers = roster.Where(x => x.Class == Class).ToArray();
            roster.RemoveAll(x => x.Class == Class);
            return kickedPlayers;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
