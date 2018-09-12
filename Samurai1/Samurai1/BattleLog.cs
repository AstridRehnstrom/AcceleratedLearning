using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai1
{
    public class BattleLog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Battle Battle { get; set; }
        public List<BattleEvent> BattleEvents { get; set; }

        public int BattleId { get; set; }
    }
}
