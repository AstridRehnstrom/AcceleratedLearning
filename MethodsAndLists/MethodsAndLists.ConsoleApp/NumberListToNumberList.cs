using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToNumberList
    {
        public void Run()
        {
            // Demo: dubblera alla tal i listan
            // Demo: dubblera alla tal i listan. Hoppa över negativa tal.

            /*
                Addera 100 till varje siffra i listan

                List<int> result = Add100ToEachNumber(new List<int> {5, 15, 23, 200});

                ==> 105, 115, 123, 300
             */
            List<int> result = Add100ToEachNumber(new List<int> { 5, 15, 23, 200 });
            Console.WriteLine("Add 100 to each number { 5, 15, 23, 200 }:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            /*
                Filtrera ut de tal som är högre än 1000
             
                List<int> result = GetNumbersHigherThan1000(new List<int>{1005, 6, 77, 200000, 666});

                ==> 1005, 200000
             */

            List<int> result2 = GetNumbersHigherThan1000(new List<int> { 1005, 6, 77, 200000, 666 });
            Console.WriteLine("Numbers higher than 1000 { 1005, 6, 77, 200000, 666 }:");

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            /*
                
                Returnera de tal som är delbara med 5

                List<int> result = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });

                ==> 20, 5, 10
             */
            List<int> result3 = GetNumbersDividableByFive(new List<int> { 20, 5, 6, 7, 10 });
            Console.WriteLine("Numbers dividable by 5 { 20, 5, 6, 7, 10 }:");

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            /*
                Dela alla tal i listan med 100

                List<int> result = DivideEachNumberBy100(new List<int> { 300,200,-500,1000 });

                ==> 3, 2, -5, 10
             */

            List<int> result4 = DivideEachNumberBy100(new List<int> { 300, 200, -500, 1000 });
            Console.WriteLine("Numbers divided by 100 { 300, 200, -500, 1000 }:");

            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            /*
                Negera alla tal i listan

                List<int> result = NegateEachNumber(new List<int> { 10, 20, -30, 40 });

                ==> -10, -20, 30, -40
             */

            List<int> result5 = NegateEachNumber(new List<int> { 10, 20, -30, 40 });
            Console.WriteLine("Negate each number { 10, 20, -30, 40 }:");

            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            /*
                Addera 50 till de tre första elementen i listan
             
                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200,300 });

                ==> 56, 66, 73, 200, 300

                List<int> result = Add50ToFirstThreeElements(new List<int> { 6, 16});
                ==> 56, 66

             */

            List<int> result6 = Add50ToFirstThreeElements(new List<int> { 6, 16, 23, 200, 300 });
            Console.WriteLine("Add 50 to three first elemnt { 6, 16, 23, 200, 300 }:");

            foreach (var item in result6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            /*
                Lägg till 70 till varannat element i listan

                List<int> result = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000});
                ==> 1000, 2070, 3000, 4070, 5000

             */
            List<int> result7 = Add70ToEverySecondElement(new List<int> { 1000, 2000, 3000, 4000, 5000 });
            Console.WriteLine("Add 70 to every second elemnt { 1000, 2000, 3000, 4000, 5000 }:");

            foreach (var item in result7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            /*
                Experimentera med att kombinera metoder, t.ex såhär:

                List<int> result = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
             */

            List<int> result8 = DivideEachNumberBy100(NegateEachNumber(new List<int> { 300, 200, -500, 1000 }));
            Console.WriteLine("Combine methods");

            foreach (var item in result8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Console.WriteLine("RESULTAT:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

        }

        private List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            var result7 = new List<int>();
            var currentIndex = 0;

            foreach (var number in numbers)
            {
                if (currentIndex % 2 == 0)
                {
                    var newNumber = number + 70;
                    result7.Add(newNumber);
                }
                else
                {
                    result7.Add(number);
                }
                currentIndex++;
            }
            return result7;
        }


        private List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            var result6 = new List<int>();

            var currentIndex = 0;

            // 10 40 20 1 2 4 
            //  0  1  2 3 4 5 

            foreach (var number in numbers)
            {
                if (currentIndex < 3)
                {
                    var newNumber = number + 50;
                    result6.Add(newNumber);
                }
                else
                {
                    result6.Add(number);    
                }
                currentIndex++;
            }
            return result6;

        }

        private List<int> NegateEachNumber(List<int> numbers)
        {
            var result5 = new List<int>();

            foreach (var number in numbers)
            {
                int sum = number * -1;
                result5.Add(sum);
            }
            return result5;
        }


        private List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var result4 = new List<int>();

            foreach (var number in numbers)
            {
                int divide = number/100;
                result4.Add(divide);
            }
            return result4;
        }



        private List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var result3 = new List<int>();

            foreach (var number in numbers)
            {
                if (number % 5 == 0)
                {
                    result3.Add(number);
                }
            }
            return result3;
        }


        private List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var result2 = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 1000)
                {
                    result2.Add(number);
                }
            }
            return result2;
        }


        private List<int> Add100ToEachNumber(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                int sum = number + 100;
                result.Add(sum);
            }
            return result;
        }
    }
}
