using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Create_circles
{
    class Circle
    {
        string name;
        int radius;


        public Circle(string n, int r)
        {
            name = n;
            radius = r;
        }

        public Circle(string n)
        {
            name = n;
            radius = 5;
        }

        public Circle()
        {
            name = "Unknown";
            radius = 5;
        }

        public void SayHello()
        {
            Console.WriteLine("I'm a circle with the name " + name);
        }

        public void WriteArea()
        {
            double area= (radius * radius) * Math.PI;
            Console.WriteLine("My name is " + name + " I have a radius of " + radius + " and an area of " +area);
        }

    }
}
