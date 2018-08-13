using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var lisa = new Person();
            {
                lisa.Gender = Gender.Female;
                lisa.FavoriteSport = FavoriteSport.Rugby;
            }


            Console.WriteLine("Lisa is " + lisa.Gender);
            Console.WriteLine("Lisa like to play " + lisa.FavoriteSport);
            Console.WriteLine("Lisa don't like to play " + FavoriteSport.Tennis);
            Console.WriteLine();
            Console.WriteLine("Here is a list of all Sport enums:");

            foreach (var sport in Enum.GetNames(typeof(FavoriteSport)))
            {
                Console.WriteLine("* " +sport);
           
            }

            Console.WriteLine();
            Console.WriteLine("Here is a orderd list of all Sport enums:");

            var sortedList = new List<String>(); // alt. List<String> x = Enum.GetNames(typeof(FavoriteSport)).ToList(); x.Sort(); foreach (sort in x) ...
            foreach (var sport in Enum.GetNames(typeof(FavoriteSport))) 
            {
                string sort = Convert.ToString(sport);
                sortedList.Add(sort);
                
            }
            sortedList.Sort();

            foreach (var sport in sortedList)
            {
                Console.WriteLine("* " + sport);

            }

            
            Console.WriteLine();
            Console.WriteLine("Write a sport: ");
            string answer = Console.ReadLine();

            if (Enum.TryParse(answer, true, out FavoriteSport sport01))
            {
               
                Console.WriteLine("Oh, I know " + sport01+"!");
            }
            else Console.WriteLine("Sorry, I don't know " + answer +".");

           
        }
    }
}
