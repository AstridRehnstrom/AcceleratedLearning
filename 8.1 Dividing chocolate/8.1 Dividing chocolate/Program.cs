using System;

namespace _8._1_Dividing_chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The chocolate contains 24 pieces");
            Console.Write("How many want to share? ");
            Console.ForegroundColor = ConsoleColor.Green;




            try
            {
                
                decimal tal = decimal.Parse(Console.ReadLine());
                decimal del = 24 / tal;
                Console.ResetColor();
                Console.WriteLine("Everyone gets " + Math.Round(del, 2) + " pieces");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero people can't divide a chocolate.");
                Console.ResetColor();
            }

            
        }
    }
}
 