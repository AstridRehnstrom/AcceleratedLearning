using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class MultipleArguments
    {
        public void Run()
        {
            /*
                Returnera närliggande elementen i listan. Den första parametern avser index för "mittenelementet".

                List<string> result = NearbyElements(3, new List<string> {"a", "b", "c", "d", "e"});
                ==> c,d,e
            
                List<string> result = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
                ==> a,b

                List<string> result = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });
                ==> d,e

            */
            Console.WriteLine("Nearby element 3, in list a, b, c, d, e");
            List<string> result = NearbyElements(3, new List<string> { "a", "b", "c", "d", "e" });
            foreach (var item in result)
            {
                Console.Write(item+ ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Nearby element 0, in list a, b, c, d, e");
            List<string> result2 = NearbyElements(0, new List<string> { "a", "b", "c", "d", "e" });
            foreach (var item in result2)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Nearby element 4, in list a, b, c, d, e");
            List<string> result3 = NearbyElements(4, new List<string> { "a", "b", "c", "d", "e" });
            foreach (var item in result3)
            {
                Console.Write(item + ", ");
            }

            /*
                Multiplicera alla tal i listan med den första parametern

                List<double> result = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
                ==> 1200, 314, 5000, 9900
             */
            Console.WriteLine();
            Console.WriteLine("Multiplicera listan {12, 3.14, 50, 99} med 100:");
            List<double> result4 = MultiplyAllBy(100, new List<double> { 12, 3.14, 50, 99 });
            foreach (var item in result4)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();


            /*
                Returnera en ny lista där vissa ord är med stora bokstäver. 
                Den andra parmetern är en lista av "bool" som anger vilka som ska vara stora.

                List<string> result = SomeToUpper(new List<string> {"what", "does", "the", "fox", "says"}, new List<bool> {true, true, false, false, true});
                ==> WHAT, DOES, the, fox, SAYS
             */

            //foreach (var element in result)
            //{
            //    Console.WriteLine(element);
            //}
            Console.WriteLine("Turn some words to upper:");
            List<string> result5 = SomeToUpper(new List<string> { "what", "does", "the", "fox", "says" }, new List<bool> { true, true, false, false, true });
            foreach (var item in result5)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private List<string> SomeToUpper(List<string> list1, List<bool> list2)
        {
            var someToUpper = new List<string>();

            for (int i = 0; i < list1.Count; i++)
            {
                if (list2[i] == true)
                {
                    var upper = list1[i].ToUpper();
                    someToUpper.Add(upper);
                }
                else
                {
                    someToUpper.Add(list1[i]);
                }
            }
            return someToUpper;
        }


        private List<double> MultiplyAllBy(int multiple, List<double> numbers)
        {
            var multipledNumbers = new List<double>();

            foreach (var item in numbers)
            {
                var newItem = item * multiple;
                multipledNumbers.Add(newItem);
            }

            return multipledNumbers;
        }


        private List<string> NearbyElements(int number, List<string> letters)
        {
            var nearby = new List<string>();

            if (number > 0)
            {
                string before = letters[number - 1];
                nearby.Add(before);
            }

            string element = letters[number];
            nearby.Add(element);

            if (number+1 < letters.Count)
            {
                string after = letters[number + 1];
                nearby.Add(after);
            }
            return nearby;
        }
    }
}
