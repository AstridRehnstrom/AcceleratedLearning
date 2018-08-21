using System;
using System.Collections.Generic;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury"};
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "David Bowie", "Freddie Mercury" };
            Console.WriteLine("RockstarsList, med metod för array");
            DisplayArrayOfRockStars(rockstarsArray);
            Console.WriteLine();
            Console.WriteLine("RockstarsList, med metod för lista");
            DisplayListOfRockStars(rockstarsList);
            Console.WriteLine();
            Console.WriteLine("RockstarsList, med metod för IEnumerable, input array");
            DisplayRockStars(rockstarsArray);
            Console.WriteLine();
            Console.WriteLine("RockstarsList, med metod för IEnumerable, input lista");
            DisplayRockStars(rockstarsList);
            string nyttnamn = "Zara Larsson";
            //rockstarsArray.Add(nyttnamn); -går ej
            rockstarsList.Add(nyttnamn);
            
        }

        static void DisplayArrayOfRockStars(string[] rockstarsArray)
        {
            
            foreach (var name in rockstarsArray)
            {
                Console.WriteLine(name);
            }

        }

        static void DisplayListOfRockStars(List<string> rockstars)
        {
            foreach (var name in rockstars) 
            {
                Console.WriteLine(name);
            }
        }

        static void DisplayRockStars(IEnumerable<string> rockstars)
        {
            foreach (var name in rockstars)
            {
                Console.WriteLine(name);
            }
        }

    }
}
