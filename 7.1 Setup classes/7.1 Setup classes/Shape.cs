﻿using System;
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

        public override string ToString()
        {
            return "Jag är en triangel med basen " + bas + " och höjden " + height;
        }
    }

    class Circle : Shape
    {
        public int radius { get; set; }

        public override string ToString()
        {
            return "Jag är en cirkel med radien " + radius;
        }

    }


    class Rectangle : Shape
    {
        public int bas { get; set; }
        public int height { get; set; }

        public override string ToString()
        {
            return "Jag är en rektangel med basen " + bas + " och höjden " + height;
        }
    }
}
