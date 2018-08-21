using System;
using System.Collections.Generic;

namespace Combine_two_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string> { "a", "b", "c"};
            List<int> lista2 = new List<int> { 1, 2, 3 };

            List<string> listaTotal = new List<string>();

            for (int i = 0; i < lista1.Count; i++)
            {
                listaTotal.Add(lista1[i]);
                listaTotal.Add(lista2[i].ToString());

            }


            for (int i = 0; i < listaTotal.Count; i++)
            {
                if (i < listaTotal.Count - 1)
                {
                    Console.Write($"{listaTotal[i]},");
                }
                else
                {
                    Console.Write($"{listaTotal[i]}");
                }

            }
            Console.WriteLine();




            //foreach (var item in listaTotal)
            //{
            //    Console.Write($" {item},");
            //}


        }
    }
}
