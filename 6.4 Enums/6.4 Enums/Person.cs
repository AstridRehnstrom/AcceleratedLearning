using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Enums
{
    public enum Gender
    {
        Female, Male, Other
    }

    public enum FavoriteSport
    {
        Tennis, Rugby, Soccer, Hurling, Squash
    }

    public class Person
    {



        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        public FavoriteSport FavoriteSport { get; set; }
       
    }
}
