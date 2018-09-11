using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai1
{
    public class Battle
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Brutal { get; set; }
        public DateTime WarStart { get; set; }
        public DateTime WarEnd { get; set; }

        public BattleLog BattleLogId { get; set; }
    }
}
