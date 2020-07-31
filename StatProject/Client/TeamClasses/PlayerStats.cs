using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatProject.Client.TeamClasses
{
    public class PlayerStats
    {
        public int AttackAttempt { get; set; }
        public int AttackError { get; set; }
        public int AttackKill { get; set; }
        public int SetAttempt { get; set; }
        public int SetError { get; set; }
        public int SetAssist { get; set; }
        public int Defense0 { get; set; }
        public int Defense1 { get; set; }
        public int Defense2 { get; set; }
        public int Defense3 { get; set; }
        public int ServeAttempt { get; set; }
        public int ServeError { get; set; }
        public int ServeAce { get; set; }
    }
}
