using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Working_with_different_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int old = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your favorite character?");
            char letter = Convert.ToChar(Console.ReadLine()); 
           
            Console.WriteLine("Thank you!");
            int retirement = 65 - old;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You have " + retirement + " years to retirement");

            if (char.IsNumber(letter))
            {

                Console.WriteLine("You like numbers");
            }

            else if (char.IsLetter(letter))
            {
                Console.WriteLine("You don't like numbers");
            }

            if (name == "Astrid") 
            {
                Console.Beep();
            }
        }
    }
}
