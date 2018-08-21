using System;
using System.Collections.Generic;

namespace MakeFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string> { "Hello", "World", "in", "a", "frame" };

            Console.WriteLine("*******");

            foreach (var item in input)
            {
                Console.WriteLine("*"+item.PadRight(5)+ "*");
            }

            Console.WriteLine("*******");
        }
    }
}
