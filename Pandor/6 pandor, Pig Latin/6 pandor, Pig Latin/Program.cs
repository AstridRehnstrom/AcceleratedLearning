using System;
using System.Linq;

namespace _6_pandor__Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {

            // taking the first letter of every word, moving it to the end of the word and adding ‘ay’. 
            string input = "The quick brown fox";
            string[] words = input.Split(" ");

            foreach (var item in words)
            {
                
                var x = new string( item.Skip(1).ToArray());
                var y = new string( item.Take(1).ToArray());

                Console.Write(" " + x+ y+ "ay");

            }
            Console.WriteLine();
        }
    }
}
