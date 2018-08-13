using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6_If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number2 to be compared to: ");
            int number2 = int.Parse(Console.ReadLine());
            

            if (number2>number1)
            {
                Console.WriteLine("Lower than " + number2);
            }
            if (number1==number2)
            {
                Console.WriteLine("Equal to " + number2);
            }

            else if (number2<number1)
            {
                Console.WriteLine("Higher than " + number2);
            }
        }
    }
}
