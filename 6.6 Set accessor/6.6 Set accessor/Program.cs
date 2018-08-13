﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_Set_accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var adress = new Adress();

            adress.Street = "Långa gatan";
            adress.StreetNumber = "13B";
            adress.City = "Sundsvall";
            adress.SetZipCode("111 22");


            Console.WriteLine("Street            " + adress.Street);
            Console.WriteLine("StreetNumber      " + adress.StreetNumber);
            Console.WriteLine("City              " + adress.City);
            Console.WriteLine("ZipCode           " + adress.GetZipCode());
            Console.WriteLine("FullStreet        " + adress.GetFullStreet());
            Console.WriteLine("FullStreet        " + adress.FullStreet);

            adress.SetZipCode("banan");
            Console.WriteLine(adress.GetZipCode() );

            adress.SetZipCode("456 96");
            Console.WriteLine(adress.GetZipCode());


        }
    }
    
}
