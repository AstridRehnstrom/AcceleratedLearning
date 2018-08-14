using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Böcker_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book();

            b1.SetIsbn("978-3-16-148410-0");
            b1.SetAuthor("Kalle");
            b1.SetNrOfPages(400);

            Console.WriteLine($"Info om boken:");
            Console.WriteLine();
            Console.WriteLine($"   ISBN:        {b1.GetIsbn()}");
            Console.WriteLine($"   Författare:  {b1.GetAuthor()}");
            Console.WriteLine($"   Antal sidor: {b1.GetNrOfPages()}");
            Console.WriteLine($"   Vikt:        {b1.WeightInGram(b1.GetNrOfPages())} gram");
            Console.WriteLine($"   Storlek:     {b1.Size(b1.GetNrOfPages())}");
            Console.WriteLine();
        }
    }
}
