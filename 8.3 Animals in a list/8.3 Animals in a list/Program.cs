using System;
using System.Text.RegularExpressions;

namespace _8._3_Animals_in_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of animals: ");
            string inmatat = Console.ReadLine();


            try
            {
                string[] animalArray = CreateArrayOfAnimals(inmatat);

                Console.WriteLine("There are " + animalArray.Length + " animals in the list");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }



        private static string[] CreateArrayOfAnimals(string inmatat)
        {
            string[] animals = inmatat.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (inmatat == "")
                throw new ArgumentException("User don’t enter any animal");


            foreach (string animal in animals) {
                if (animal == "")
                    throw new ArgumentException("One of the animals is empty");

                if (animal.Length>20)
                    throw new ArgumentException("One of the animals has more han 20 letters");

                // f#¤%%¤&&&(
                var x = new Regex("^[a-zåäö]+$");
                if (!x.IsMatch(animal))
                {
                    throw new ArgumentException("One of the animals contains an invalid characters (just accept some letters like a-z, å,ä,ö)");
                }             

                
            }

            return animals;

        }

       
        

    }
}
