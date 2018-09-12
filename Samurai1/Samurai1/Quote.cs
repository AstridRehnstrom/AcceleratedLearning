using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samurai1
{
    public enum QuoteType
    {
        Lame, Cheesy, Awesome
    }

    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public QuoteType QuoteType { get; set; }
        public Samurai Samurai { get; set; }
    }
}
