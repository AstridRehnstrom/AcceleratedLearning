using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_Create_cubes
{
    class Cube
    {
        int height;
        int width;
        int depth;
        string color;

        public Cube(int h, int w, int d)
        {
            height = h;
            width = w;
            depth = d;
        }


        public void WriteVolume()
        {
            double volume = height * width * depth;
            Console.WriteLine("The volume of the cube is " + volume);
        }

        public double CalculateVolume()
        {
            return height * width * depth;
        }

        public void Area()
        {
            double area = (2*height*width)+(2*width*depth)+(2*depth*height);
            Console.WriteLine("The area of the cube is " + area);
        }

        public void Color()
        {
            color = "red";
        }
        
    }
}