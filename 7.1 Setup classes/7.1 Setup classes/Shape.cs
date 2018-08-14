using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Setup_classes
{
    class Shape
    {
       
    }

    class Triangle : Shape
    {
        public int bas { get; set; }
        public int height { get; set; }
    }

    class Circle : Shape
    {
        public int radius { get; set; }
    }


    class Rectangle : Shape
    {
        public int bas { get; set; }
        public int height { get; set; }
    }
}
