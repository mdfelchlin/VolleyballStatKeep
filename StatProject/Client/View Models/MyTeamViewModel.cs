using StatProject.Client.TeamClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatProject.Client.View_Models
{
    public class MyTeamViewModel
    {
        public List<Player> TeamPlayers { get; } = new List<Player>();

        public Player TempPlayer = new Player();
        public void AddPlayer()
        {
            TeamPlayers.Add(TempPlayer);

            TempPlayer = new Player();
        }
    }
}
