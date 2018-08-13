using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7_Conditional_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            string classify;


           // classify = (number > 20) ? "Higher than 20" : "Lower or equal to 20";
            //Console.WriteLine(classify);


            classify = (number==20)? "Equal to 20": (number > 20) ? "Higher than 20" : "Lower than 20";
            Console.WriteLine(classify);
        }
    }
}
