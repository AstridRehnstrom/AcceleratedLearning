using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai1
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}
