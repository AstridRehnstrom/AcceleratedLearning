using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Create_circles
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);
            Circle ali = new Circle("Ali");
            Circle circle = new Circle();

            bob.SayHello();
            lisa.SayHello();
            ali.SayHello();
            circle.SayHello();

           Console.WriteLine();

           bob.WriteArea();
           lisa.WriteArea();
           ali.WriteArea();
           circle.WriteArea();


        }
    }



    

}



