using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Times to repeat: ");
            int times = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Your name is " + name);
            }


            Console.WriteLine("number of rows?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number of columns?");
            int col = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();
                                       
                for (int j = 0; j < col; j++)
                {
                    Console.Write(name + "   ");
                }

            }
        }
    }
}
