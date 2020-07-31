using System;

namespace StatProject.Client.TeamClasses
{
    public class Player
    {
        public int JerseyNumber { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Position { get; set; } = String.Empty;
        public PlayerStats Stats { get; set; } = new PlayerStats();
    }
}
