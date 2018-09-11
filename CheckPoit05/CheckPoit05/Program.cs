using System;
using System.Collections.Generic;

namespace CheckPoit05
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccess = new DataAccess();
            List<Gnomes> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);
            Console.WriteLine("Lägg till en ny tomte: ");
            string name= Console.ReadLine();
            //dataAccess.AddGnome(name);
            // ex på kod som kan deletea hela databasen: Kalle'); Delete from Gnome; -- 
            dataAccess.AddGnome2(name);
        }

        private static void DisplayGnomes(List<Gnomes> gnomes)
        {
            Console.WriteLine(@"NAMN        HAR SKÄGG      ÄR OND       TEMPERAMENT    RAS");
            foreach (Gnomes g in gnomes)
            {
                //Console.WriteLine(g.Name.PadRight(12)+ g.Skägg.PadRight(15) + g.Ond.PadRight(13) + g.Temperament.ToString().PadRight(15) + g.Ras);
                Console.WriteLine(g.Name);
            }
        }       
    }
}
