using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai1
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string SecretName { get; set; }
        public Samurai Samurai { get; set; }

        public int SamuraiId { get; set; }
    }
}
