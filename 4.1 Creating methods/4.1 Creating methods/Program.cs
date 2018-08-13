using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Creating_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var inmatat= GetInputFromUser();
            
            var names= CreateArrayOfPeople(inmatat);

            RespondToUser(names);

        }

        static string GetInputFromUser()
        {
            Console.WriteLine("Enter names seperated by comma (eg. Maria,Peter,Lisa)");
            string inmatat = Console.ReadLine();
            inmatat = inmatat.ToUpper();
            return inmatat;
        }

        static string[] CreateArrayOfPeople(string inmatat)
        {
            string[] names = inmatat.Split(',');
            return names;
        }

        static void RespondToUser(string[] names)
        {
            foreach (string name in names)

            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("***" + "SUPER-" + name + "***");
                Console.ResetColor();
            }

        }
    } 

}
