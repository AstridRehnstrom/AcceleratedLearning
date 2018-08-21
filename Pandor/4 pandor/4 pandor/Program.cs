using System;

namespace _4_pandor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett ord och kolla om det är ett palindrom");
            string inmatat = Console.ReadLine();

            bool isPalindrome = IsPalindrome(inmatat);


            if (isPalindrome == true)
            {
                Console.WriteLine("Det är ett palindrom");
            }
            else
            {
                Console.WriteLine("Det är inte ett palindrom");
            }

        }

        private static bool IsPalindrome(string s)
        {
            bool isPalinrom = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    isPalinrom = false;

                }
            }

            return isPalinrom;


        }
    }
}

