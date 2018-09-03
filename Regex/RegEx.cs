using System;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            string x =  "DE-234-456";
            Regex reg = new Regex(@"^([A-Z]{1,2})-(\d\d\d)-(\d\d\d)$");
            Match match = reg.Match(x);

            if (reg.IsMatch(x))
            {
                Console.WriteLine(x);
                string y = match.Groups[1].Value;
                Console.WriteLine(y);
                string yy = match.Groups[2].Value;
                Console.WriteLine(yy);
                string yyy = match.Groups[3].Value;
                Console.WriteLine(yyy);
            }



        }
    }
}
