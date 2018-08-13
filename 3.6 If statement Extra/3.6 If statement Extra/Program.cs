using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_If_statement_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Random guess = new Random();
            int slumpad = guess.Next(0, 100);

            int counter = 0;
            Console.WriteLine("Guess a number, yo have 6 tries: ");

            while (counter < 7)
            {
                
                int inmatat = int.Parse(Console.ReadLine());

                if (inmatat < slumpad)
                {
                    Console.WriteLine("Your guess is to low, guess again");
                }
                else if (inmatat > slumpad)
                {
                    Console.WriteLine("Your guess is to high, guess again");
                }
                if (inmatat == slumpad)
                {
                    Console.WriteLine("Correct!!");
                    break;
                }
                counter++;

            }
        }
    }
}
