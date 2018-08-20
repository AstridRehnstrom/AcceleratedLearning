using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint02
{
    class Rum
    {
        public string VilketRum { get; set; }
        public int Storlek { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {         
            var allaRum = new List<Rum>();
            Console.Write("Ange namn på rum: ");
            string inmatat = Console.ReadLine();
            string[] delaUpp = inmatat.Split('|');


            foreach (var line in delaUpp)
            {

                var splittedLine = line.Split(' ');
                var vilketrum = splittedLine[0];
                var storlek = splittedLine[1];



                var ettRum = new Rum();

                ettRum.VilketRum = vilketrum;
                ettRum.Storlek = int.Parse(storlek.Remove(storlek.Length - 2));
                allaRum.Add(ettRum);
            }


            foreach (var item in allaRum)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*Rumnamn: " + item.VilketRum + item.Storlek);
                

            }



            //var maxRum = allaRum.Max(t => t.Storlek);
            
            //Console.WriteLine("Störta rummet är på " + maxRum +"m2");
            //Console.ResetColor();


            var maxRum = allaRum.OrderBy(t => t.Storlek);

     

            foreach (var item in maxRum)
            {
             Console.WriteLine($"{item.VilketRum}   {item.Storlek} ");
               break;
            }
            //Console.WriteLine("Störta rummet är på " + maxRum + "m2");
            //Console.ResetColor();

        }
    }
}
