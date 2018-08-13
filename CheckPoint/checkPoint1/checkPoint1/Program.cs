using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange kommando (lista av siffror separerade med streck) :");
            string inmatat = Console.ReadLine();

            string[] siffror = inmatat.Split('-');



            foreach (string siffra in siffror)
            {
                
                int nuSiffra = Convert.ToInt32(siffra);

                                
                var txt = "";
                for (int a = 0; a < nuSiffra; a++)
                {
                    Console.WriteLine(txt += "*");
                }
            }



        }

    }  
}
