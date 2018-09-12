using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai1
{
    public enum HairStyleType
    {
        Chonmage, Oicho, Western
    }

    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecretIdentity SecretIdentityId { get; set; }
        public HairStyleType HairStyle { get; set; }
        public List<Quote> Quote { get; set; }
        public List<SamuraiBattle> SamuraiBattle { get; set; }

    }
}
