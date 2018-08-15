using System;
using System.IO;

namespace _9._2_Watch_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new FileSystemWatcher();

            x.Path = @"c:\TMP";
            Console.WriteLine("I'm watching this folder " + x.Path);
        
            x.EnableRaisingEvents = true;

            x.Created += EnFilHarLagtsTill;
            x.Deleted += EnFilHarTagitsBort;
            x.Changed += EnFilHarÄndrats;

            Console.ReadKey();
           
        }

        private static void EnFilHarÄndrats(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.Name + " har ändrats!");
        }

        private static void EnFilHarTagitsBort(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.Name + " har tagits bort!");
        }

        private static void EnFilHarLagtsTill(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.Name + " har skapats!");
        }

     


    }


}
