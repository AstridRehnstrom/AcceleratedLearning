using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint06
{
    public class Ravioli
    {
        //All ravioli har ett packdatum och ett bästföredatum. Bästföredatumet är alltid 6 månader och 15 dagar senare än packdatumet.
        public int Id { get; set; }
        public DateTime Packed { get; set; }
        public DateTime BestBefore { get; set; }
        public List<RavioliInSpaceship> RavioliInSpaceship { get; set; }

    }
}
