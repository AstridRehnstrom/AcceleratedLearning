using System;
using System.IO;

namespace _8._2_Files_and_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                Console.Write("Enter a file name: ");

                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    var filename = Console.ReadLine();
                    Console.ResetColor();
                    File.CreateText(filename);
                    Console.WriteLine("The file " + filename + " is now created.");
                    break;
                }
                catch (UnauthorizedAccessException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You aren’t allowed to create the file here");
                }

                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid filename");
                    Console.ResetColor();
                }

                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The folder don’t exist");
                    Console.ResetColor();
                }

            }


        }
    }
}
