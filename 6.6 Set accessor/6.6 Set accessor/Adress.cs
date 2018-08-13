using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6._6_Set_accessor
{
    class Adress
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        //public string ZipCode { get; set; }

        private string ZipCode01;

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

        public void SetZipCode(string z)
        {


            if (Regex.IsMatch(z, @"^[0-9]{3} [0-9]{2}$"))
                {
                ZipCode01 = z;
                }
            
        }

        public string GetZipCode()
        {
            return ZipCode01;
        }

    }
}
