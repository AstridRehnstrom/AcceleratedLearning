using System;

namespace _8._1_Dividing_chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The chocolate contains 24 pieces");
           
            
            int retries = 0;

            while (true)
            {

                try
                {
                    Console.Write("How many want to share? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    decimal tal = decimal.Parse(Console.ReadLine());
                    decimal del = 24M / tal;
                    Console.ResetColor();
                    Console.WriteLine("Everyone gets " + Math.Round(del, 2) + " pieces");
                    break;
                }

                catch (FormatException)
                {
                    Console.ResetColor();
                    Console.WriteLine("Det är fel på formatet");
                    if (retries < 3)
                        retries++;
                    else
                        throw;
                }

                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zero people can't divide a chocolate.");
                    Console.ResetColor();
                    if (retries < 3)
                        retries++;
                    else
                        throw;
                }

            }
        }
    }
}
