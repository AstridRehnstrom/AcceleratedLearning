using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToString
    {

        public void Run()
        {

            /*
            
                Returnera en text som talar om vilket det första och sista numret är i listan

                string result = ReportFirstAndLastValue(new List<int> {5, 1000, 2000, 3000, 6});

                ==>    Första siffran är 5 och sista siffran är 6
             */
            string result = ReportFirstAndLastValue(new List<int> { 5, 1000, 2000, 3000, 6 });
            Console.WriteLine("First and last value: ");
            Console.WriteLine(result);

            /*
             
                Returnera en text som säger om alla nummer är högre än 100 eller inte.

                string result = ReportIfAllValuesAreHigherThan100(new List<int> {200, 105, 150});
                ==>    Alla nummer är högre än 100

                string result = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
                ==>    Något nummer är lägre än 100

             */
            Console.WriteLine("Are all numbers in list higher than 100?");
            Console.WriteLine("{ 200, 105, 150 }");
            string result2 = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 105, 150 });
            Console.WriteLine(result2);
            Console.WriteLine("{ 200, 98, 150 }");
            string result3 = ReportIfAllValuesAreHigherThan100(new List<int> { 200, 98, 150 });
            Console.WriteLine(result3);

            /*
                Returnera en text hur många negativa tal som finns i listan

                string result = ReportNumberOfNegativeValues(new List<int> {5, 7, -2, 100, -4});
                ==>     Det finns 2 st negativa tal i listan

                string result = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
                ==>     Jippi! Det finns inga negativa tal i listan
             */
            Console.WriteLine("Are there any negative numbers in the list?");
            Console.WriteLine("{5, 7, -2, 100, -4}");
            string result4 = ReportNumberOfNegativeValues(new List<int> { 5, 7, -2, 100, -4 });
            Console.WriteLine(result4);
            Console.WriteLine("{ 5, 7, 44, 100, 33 }");
            string result5 = ReportNumberOfNegativeValues(new List<int> { 5, 7, 44, 100, 33 });
            Console.WriteLine(result5);

            //Console.WriteLine("RESULT");
            //Console.WriteLine(result);

        }

        private string ReportNumberOfNegativeValues(List<int> numbers)
        {
            var negativeNumbers = new List<int>();

            foreach (var item in numbers)
            {
                if (item < 0)
                {
                    negativeNumbers.Add(item);
                }         
            }

            if (negativeNumbers.Count > 0)
            {
                return "There are " + negativeNumbers.Count + " negative numbers in the list.";
            }
            else
            return "Yippie, there are no negative numbers in the list.";

        }


        private string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            if(numbers.Count == 0)
            {
                return "List is empty!";

            }
            foreach (var item in numbers)
            {
                if (item < 100)
                {
                    return "Not all numbers are higher than 100.";
                }
            }
            return "All numbers are higher than 100.";

        }


        private string ReportFirstAndLastValue(List<int> numbers)
        {
            return "First value is " + numbers[0] + " and last value is " + numbers[numbers.Count - 1]+".";
        }
    }
}