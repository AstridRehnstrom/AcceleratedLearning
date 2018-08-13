using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_Validation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names;

            while (true) {
                var inmatat = GetInputFromUser();
                names = CreateArrayOfPeople(inmatat);
                CleanUpArray(names);

                if (PeopleArrayIsValid(names))
                break;
            }

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
            string[] names = inmatat.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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

        static bool PeopleArrayIsValid(string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("The list don't contain any names");
                return false;
            }
                        

            foreach (string name in names)
            {
                if (1 >= name.Length || name.Length > 9)
                {
                    Console.WriteLine("A person can only have 2 to 9 letters");
                    return false;
                }
             
               
            } return true;
    

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
