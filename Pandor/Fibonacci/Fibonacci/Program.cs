using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that computes the list of the first 100 Fibonacci numbers, 1 1 2 3 5 8 13 
            //1, 1, 1+1=2, 1+2=3, 2+3=5, 3+5=8.
            decimal first = 1;
            decimal second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);


            for (int i = 0; i < 100; i++)
            {
                decimal next = first + second;
                first = second;
                second = next;
                Console.WriteLine(next);

                
            }
        }
    }
}
