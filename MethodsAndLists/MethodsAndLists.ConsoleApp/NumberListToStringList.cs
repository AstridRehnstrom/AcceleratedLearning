using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class NumberListToStringList
    {

        public void Run()
        {
            /*
                Lägg till tre stjärnor innan och efter siffran
                
                List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });

                ==>  ***1003***, ***20***, ***-130***, ***2040***
            */
            Console.WriteLine("Add stars!");
            List<string> result = AddStars(new List<int> { 1003, 20, -130, 2040 });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            /*
                Samma men lägg bara till stjärnor runt de som är större än 1000
             
                List<string> result = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });

                ==>   ***1003***, 20, -130, ***2040***
            */
            Console.WriteLine("Add stars on numbers higher than 1000!");
            List<string> result1 = AddStarsToNumbersHigherThan1000(new List<int> { 1003, 20, -130, 2040 });
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            /*
                Negativa tal => "ZIP"
                Positiva tal => "ZAP"
                Noll         => "BOING"
            
                List<string> result = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
 
                =>    ZAP, ZAP, ZIP, BOING, ZAP
            */
            Console.WriteLine("Zip, Zap, Boing:");
            List<string> result2 = NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(new List<int> { 1003, 20, -130, 0, 2040 });
            foreach (var item in result2)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            /*
              
                Skapa en lista av strängar som meddelar om personen är kort eller lång (över 160cm). Hoppa över orimliga värden

                List<string> result = LongOrShort(new List<int> {170, 130, 205, -10, 600, 180});

                ==>    LÅNG, KORT, LÅNG, LÅNG

             */
            Console.WriteLine();
            Console.WriteLine("kort eller lång?");
            List<string> result3 = LongOrShort(new List<int> { 170, 130, 205, -10, 600, 180 });
            foreach (var item in result3)
            {
                Console.Write(item + ",");
            }

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }

        private List<string> LongOrShort(List<int> numbers)
        {
            var longOrShort = new List<string>();

            foreach (var number in numbers)
            {
                if (number < 160 && number > 50)
                {
                    var kort = "KORT";
                    longOrShort.Add(kort);
                }
                if (number > 160 && number < 250)
                {
                    var lång = "LÅNG";
                    longOrShort.Add(lång);
                }
            }
            return longOrShort;
        }


        private List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            //Negativa tal => "ZIP"
            //Positiva tal => "ZAP"
            //Noll => "BOING"
            var zipZap = new List<string>();

            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    var zip = "ZIP";
                    zipZap.Add(zip);
                }
                if (number > 0)
                {
                    var zap = "ZAP";
                    zipZap.Add(zap);
                }
                if (number == 0)
                {
                    var boing = "BOING";
                    zipZap.Add(boing);
                }
            }
            return zipZap;
        }

        private List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            var withStars = new List<string>();

            foreach (var number in numbers)
            {
                if (number > 1000)
                {
                    var stars = "***" + number + "***";
                    withStars.Add(stars);
                }
                if (number < 1000)
                {
                    withStars.Add(number.ToString());
                }
            }
            return withStars;
        }


        private List<string> AddStars(List<int> numbers)
        {
            var withStars = new List<string>();

            foreach (var number in numbers)
            {
                var stars = "***" + number + "***";

                withStars.Add(stars);
            }
            return withStars;
        }
    }
}