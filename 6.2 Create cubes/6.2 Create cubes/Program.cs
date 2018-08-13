using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_Create_cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            mycube.WriteVolume();
            supercube.WriteVolume();

            double volume = mycube.CalculateVolume();
            Console.WriteLine($"Volume: {volume}");

            double supervolume = supercube.CalculateVolume();
            Console.WriteLine($"Volume: {supervolume}");

            mycube.Area();
            supercube.Area();
            
            
            
        }
    }
}
