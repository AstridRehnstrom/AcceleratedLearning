using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("SKAPAR HISSEN KALLE");
            var e1 = new Elevator("Kalle", -2, 10, 5, 2);
            Console.WriteLine("     " + e1.Report());
            Console.WriteLine ("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            Console.WriteLine ("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            Console.WriteLine ("Signal till Kalle att åka upp en våning");
            e1.GoUp();
            Console.WriteLine("     " + e1.Report());

            // Test av Lisa (hissen är redan på lägsta nivå så kommer inte åka nånstans)

            Console.WriteLine ("SKAPAR HISSEN LISA");
            var e2 = new Elevator("Lisa", 5, 8);
            Console.WriteLine("     " + e2.Report());
            Console.WriteLine ("Signal till Lisa att åka ner en våning");
            e2.GoDown();
            Console.WriteLine("     " + e2.Report());
        }
    }
}
