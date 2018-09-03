using System;
using System.Collections.Generic;

namespace Checkpoint03
{
    class Program
    {
        static void Main(string[] args)
        {
            //NIVÅ 1, Multiplicera varje tal med 100 och lägg till 3
            //förväntat resultat: 203 803 303 1103

            List<int> resultat = MultipleBy100AndAdd3(new List<int> { 2, 8, 3, 11 });

            foreach (var item in resultat)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //nivå 2
            List<string> result1 = ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 1, 2, 3, 5, 4 });
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

        }
 


    private static List<string> ReorderList(List<string> list1, List<int> list2)
    {
        var newList = new List<string>();

        foreach (var item in list2)
        {
            newList.Add(list1[item - 1]);
        }
        return newList;
    }

    static List<int> MultipleBy100AndAdd3(List<int> numbers)
    {
        var multiple = new List<int>();

        foreach (var number in numbers)
        {
            int sum = number * 100 + 3;
            multiple.Add(sum);
        }
        return multiple;
    }


} 
}
