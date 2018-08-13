using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5_Get_accessor
{
    class Address
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }


        public string GetFullStreet()
        {
            return Street + " " + StreetNumber;

        }

        public string FullStreet
        {
            get
            {
                return Street + " " + StreetNumber;
            }
        }
    }
}