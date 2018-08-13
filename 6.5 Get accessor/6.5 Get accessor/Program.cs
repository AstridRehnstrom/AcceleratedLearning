using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5_Get_accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var adress = new Address();

            adress.Street = "Långa gatan";
            adress.StreetNumber = "13B";
            adress.City = "Sundsvall";
            adress.ZipCode = 11122;


            Console.WriteLine("Street            " + adress.Street);
            Console.WriteLine("StreetNumber      " + adress.StreetNumber);
            Console.WriteLine("City              " + adress.City);
            Console.WriteLine("ZipCode           " + adress.ZipCode);
            Console.WriteLine("FullStreet        " + adress.GetFullStreet());
            Console.WriteLine("FullStreet        " + adress.FullStreet);
        


        }
    }
}
