using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_While__true_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Times to repeat: ");
            int times = Convert.ToInt32(Console.ReadLine());
            int n = 0;
           
            
            while (true)
            {
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your name is " + name, n);
                n++;

                if (n > times-1)
                {
                   
                    break;

                }
               
                               

            }
        }
    }
}
