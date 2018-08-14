using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book("111111", "Min bok");

            b1.Isbn="978-3-16-148410-0";
            b1.Author="Kalle";
            b1.NrOfPages=9900;
            b1.ProductId="1234";

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {b1.Isbn}");
            Console.WriteLine($"   Författare:  {b1.Author}");
            Console.WriteLine($"   Antal sidor: {b1.NrOfPages}");
            Console.WriteLine($"   Vikt:        {b1.WeightInGram(b1.NrOfPages)} gram");
            Console.WriteLine($"   Storlek:     {b1.Size(b1.NrOfPages)}");
            Console.WriteLine($"   ProductId:   {b1.ProductId}");
            Console.WriteLine();

            //bool isb1 = b1 is Book;

            Console.WriteLine("Olika test:");
            Console.WriteLine("Är b1 en bok?       " + (b1 is Book));
            Console.WriteLine("Är b1 en e-bok?     " + (b1 is ElectronicBook));
            Console.WriteLine("Är b1 en product?   " + (b1 is Product));

            Console.WriteLine();
            var e1 = new ElectronicBook("465745", "Min e-bok");
            e1.ProductId="7777";
            Console.WriteLine($"Info om e-boken:");
            Console.WriteLine($"   ProductId:   {e1.ProductId}");
            Console.WriteLine();


            Console.WriteLine("Olika test:");
            Console.WriteLine("Är e1 en bok?       " + (e1 is Book));
            Console.WriteLine("Är e1 en e-bok?     " + (e1 is ElectronicBook));
            Console.WriteLine("Är e1 en product?   " + (e1 is Product));

            Console.WriteLine();
            Console.WriteLine("Anrop:");
            e1.SendBookTo("astrid@gemigboken.nu");
        }
    }
}
