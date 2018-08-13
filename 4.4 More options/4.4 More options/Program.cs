using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4_More_options
{
    class Program
    {
        static void Main(string[] args)
        {
            char seperator = AskUserForSeparator();
            bool showErrorMessage = AskUserForErrorMessage();

            string[] names;

            while (true)
            {
                var inmatat = GetInputFromUser();
                names = CreateArrayOfPeople(inmatat, seperator);
                CleanUpArray(names);


                if (PeopleArrayIsValid(names, showErrorMessage))
                    break;
            }

            RespondToUser(names);
        }

        static char AskUserForSeparator()
        {
            Console.WriteLine("Which separator do you want to use? (comma is default)?");
            char separator = Convert.ToChar(Console.ReadLine());
            return separator;
        }

        static bool AskUserForErrorMessage()
        {
            Console.WriteLine("Do you want to see error message? (default is yes)?");
            string error = Console.ReadLine().ToUpper().Trim();
            if (error == "YES") return true;
            else return false;
        }


        static string GetInputFromUser()
        {
            Console.WriteLine("Enter names separated by your separator (eg. Maria,Peter,Lisa)");
            string inmatat = Console.ReadLine();
            inmatat = inmatat.ToUpper();
            return inmatat;
        }


        static string[] CreateArrayOfPeople(string inmatat, char separator)
        {
            string[] names = inmatat.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            return names;
        }


        static string[] CleanUpArray(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim();
            }
            return names;
        }


        static bool PeopleArrayIsValid(string[] names, bool showErrorMessage)
        {

            if (names.Length == 0)
            {
                if (showErrorMessage == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The list don't contain any names");
                    Console.ResetColor();
                }
                return false;
            }


            foreach (string name in names)
            {
                if (name.Length <= 1 || name.Length >= 10)
                {
                    if (showErrorMessage == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A person can only have 2 to 9 letters");
                        Console.ResetColor();
                    }
                    return false;
                }
            }
            return true;
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
