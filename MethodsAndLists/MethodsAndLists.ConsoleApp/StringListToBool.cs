using System;
using System.Collections.Generic;

namespace MethodsAndLists.ConsoleApp
{
    public class StringListToBool
    {
        public void Run()
        {
            // Demo: Returerna "true" om längen på alla ord tillsammans är större än 10

            /*
                Returnera "true" om alla ord har fem eller fler tecken
             
                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
                ==> true

                bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
                ==> false
            */

            //Console.WriteLine(result);

            Console.WriteLine("True or False?");
            Console.WriteLine("abcdef, friday, ooooooooo");
            bool result = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "friday", "ooooooooo" });
            Console.WriteLine(result);
            Console.WriteLine("abcdef, fri, ooooooooo");
            bool result2 = AllWordsAreFiveLettersOrLonger(new List<string> { "abcdef", "fri", "ooooooooo" });
            Console.WriteLine(result2);
        }


        private bool AllWordsAreFiveLettersOrLonger(List<string> list)
        {
            foreach (var item in list)
            {
                if (item.Length < 5)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
