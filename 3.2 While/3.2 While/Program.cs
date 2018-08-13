using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_While
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
            while (n < times)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your name is " + name);
                n++;
            }

            int m = 0;
            while (m < times)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                string result = string.Format("Your name is:{0} ", name);
                Console.WriteLine(result);
                m++;

            }

            int q = 0;
            while (q < times)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                var result2 = $"Your name is: {name}";
                Console.WriteLine(result2);
                q++;

            }

        }
    }
}
