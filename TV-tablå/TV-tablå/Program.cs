using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TV_tablå
{
   
    class Show
    {
        public string Channel { get; set; }
        public TimeSpan StartAt { get; set; }
        public string Title { get; set; }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
           var allLines= File.ReadAllLines("TV-data.txt");

            var allShows = new List<Show>();

            foreach (var line in allLines)
            {

                var splitteLine= line.Split('*');
                var channel = splitteLine[0];
                var time = splitteLine[1];
                var title = splitteLine[2];

                var show = new Show();

                show.Title = title;
                show.Channel = channel;
                show.StartAt = TimeSpan.Parse(time);

                allShows.Add(show);
            }
            

            Header("alla shower");

            foreach (var show in allShows)
            {
                Console.WriteLine(show.Title);
            }

            Header("alla kanaler");
            
            foreach (var show in allShows)
            {
                Console.WriteLine(show.Channel);
            }


            var laterThan21 = new List<Show>();

            foreach (var show in allShows)
            {
                if (show.StartAt.Hours >= 21)
                {
                    laterThan21.Add(show);
                }                
            }

          
            Header("Program som börjar senare än 21:");
            foreach (var show in laterThan21)
            {
                WriteInfoAboutShow(show);            
            }


            Header("Program som börjar senare än 21, mha linq:");

            var resultat = allShows.Where(show => show.StartAt.Hours >= 21);

            foreach (var show in resultat)
            {
                WriteInfoAboutShow(show);
            }

            Header("Program på svt1 sorterade i kronologisk ordning");
            var svt1sort= allShows.Where(x => x.Channel == "SVT1").OrderBy(x => x.StartAt);

            foreach (var show in svt1sort)
            {
                WriteInfoAboutShow(show);
            }

        }


        private static void Header(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + text.ToUpper() + "\n");
            Console.ResetColor();
        }


        private static void WriteInfoAboutShow(Show show)
        {
            Console.WriteLine(show.Channel.PadRight(4) + "    " + show.StartAt + " " + show.Title);
        }

       
    }
    
}
