using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaappen_2._0.Domain
{
    public class GetAPI
    {
        public bool Success { get; set; }
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public object Rates { get; set; }

        public List<Currency> Currencies { get; set; }
    }
}

