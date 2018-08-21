using System;

namespace _1_panda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Skriv ditt namn:");
            //string namn = Console.ReadLine();
            //Console.WriteLine("Hej " + namn);

            //Console.WriteLine("Skriv ditt namn:");
            //string namn = Console.ReadLine();

            //if (namn == "Alice" || namn == "Bob") 
            //{
            //    Console.WriteLine("Hej " + namn);
            //}


            Console.WriteLine("Skriv ett nummer: ");
            int nummer = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < nummer+1; i++)
            {

                sum = sum + i;
               

            }
            Console.WriteLine("summan är: " + sum);

           

        }
    }
}
