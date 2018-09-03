using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reseapp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool meny = true;
            while (meny)
            {
                Console.WriteLine("Välkommen till reseappen");
                Console.WriteLine("Skriv V för att kolla valuta, skriv T för att kolla tidszon");

                Console.WriteLine("[V] Valuta");
                Console.WriteLine("[T] Tidszon");
                Console.WriteLine("[Q]uit");

                Console.Write("\n\n");

                string val = Console.ReadLine().ToUpper().Trim();

                switch (val)
                {
                    case "V":
                        Console.WriteLine("Vilken valuta vill du konvertera?");
                        Console.WriteLine("[E] Euro");
                        Console.WriteLine("[U] US Dollar");
                        Console.WriteLine("[P] Brittiska Pund");
                        Console.WriteLine("[D] Danska kronor");
                        Console.WriteLine("[T] Thailändska batt");
                        Console.WriteLine("[K] Kroatiska Kuna");
                        Console.WriteLine("[A] Australiska dollar");
                        decimal valdValuta = 0;
                        Console.WriteLine();

                        while (true)
                        {
                            string valValuta = Console.ReadLine().ToUpper().Trim();
                            
                            
                            try
                            {
                                valdValuta= ValutaVal(valValuta);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du har matat in ett felaktigt värde, mata in ett nytt");
                            }
                        }

                        Console.WriteLine("Ange i svenska kronor hur mycket du vill konvertera");
                        decimal inmatad = decimal.Parse(Console.ReadLine());
                        var total=Math.Round(Valutauträknare(valdValuta, inmatad), 2);
                        Console.WriteLine(inmatad + "svenska kronor blir "+total+ " i vald valuta");

                        break;

                       


                    case "T":


                        break;

                    case "Q":


                        Console.WriteLine("Programmet avslutas");
                        meny = false;

                        break;




                    default:
                        break;
                }
            }
        }

        private static decimal Valutauträknare(decimal valdValuta, decimal inmatad)
        {
            var summa = inmatad / valdValuta ;
            return summa;
        }



        private static decimal ValutaVal(string valValuta)
        {

            switch (valValuta)
            {
                case "E":
                    return 11.17M;

                case "U":
                    return 9.74M;

                case "P":
                    return 12.45M;

                case "D":
                    return 1.48M;

                case "T":
                    return 0.31M;

                case "K":
                    return 1.53M;

                case "A":
                    return 7.15M;
            }
            throw new Exception(); 
        }








    }
}

