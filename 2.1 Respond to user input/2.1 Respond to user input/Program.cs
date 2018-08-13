using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Respond_to_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int old = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite letter?");
            string letter = Console.ReadLine();
            Console.WriteLine("Where do you live?");
            string live = Console.ReadLine();
            Console.WriteLine("Thank you!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are " + old + " years old");
            Console.WriteLine("Your favorite letter is " + letter);
            Console.WriteLine("You live in " + live);

        }
        
        

        
        
    }
}
