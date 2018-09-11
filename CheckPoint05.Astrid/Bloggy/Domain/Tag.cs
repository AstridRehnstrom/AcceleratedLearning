using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy.Domain
{
    public class Tag
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public int BlogPostId { get; set; }
        public BlogPost Blogpost { get; set; }
    }
}
