﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy.Domain
{
    public class BlogPost
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public List<Comment> Comments { get; set; }
        public int TagId { get; set; }
    }
}
