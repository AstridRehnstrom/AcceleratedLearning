using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter names in a list (like Maria, Peter, Lisa: )");
            string inmatat= Console.ReadLine();


            
            string[] words = inmatat.Split(',');
            foreach (string name in words)

               
            {
                Console.WriteLine(name + " Andersson");
            }

                
            
        }
    }
}
