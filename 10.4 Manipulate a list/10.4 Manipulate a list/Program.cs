using System;
using System.Collections.Generic;

namespace _10._4_Manipulate_a_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> allNames = new List<string>();

            while (true)
            {

                Console.Write("Enter a name: ");
                string name = Console.ReadLine().ToLower().Trim();

                if (name == "quit")
                    break;

                allNames.Add(name);

            }
           
            allNames.Sort();
            allNames.RemoveAt(allNames.Count - 1);
            allNames.RemoveAt(0);
            Console.WriteLine();

            allNames.ForEach(x =>
            {
                Console.WriteLine("name: " + x);
            });
        }
    }



}
