using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5_Foreach_with_break
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter names in a list (like Maria, Peter, Lisa: )");
            string inmatat = Console.ReadLine();


            string[] words = inmatat.Split(',');

            bool allowZelda=false;




            foreach (string name in words)
            {

                if (name == "AllowZelda")
                {

                    allowZelda = true;
                }

            

                else if (name == "Zelda" && allowZelda == true)
                {
                    Console.WriteLine(name + " " + "Andersson");
                }

                else if (name == "Zelda")
                {
                    break;
                }

                else
                    Console.WriteLine(name + " " + "Andersson");
            }
        }
    }
} 

