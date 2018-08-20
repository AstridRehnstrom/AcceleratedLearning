using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint2.omprov
{

    class Furniture
    {
        public string Name { get; set; }
        public int Prize { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ange möbler:");
            string input = Console.ReadLine();
            string[] furnitureArray = input.Split(new[] { ':' });

            var allFurnitures = new List<Furniture>();

            foreach (var furnitureString in furnitureArray)
            {
                var furniture = new Furniture();
                string[] pair = furnitureString.Trim().Split(',');
                string nameOfFurniture = pair[0];
                string prizeOfFurniture = pair[1];

                furniture.Name = nameOfFurniture;
                furniture.Prize = int.Parse(prizeOfFurniture);

                allFurnitures.Add(furniture);
            }

            Furniture lowestPrize = allFurnitures.OrderBy(x => x.Prize).First();
            Console.WriteLine("Den billigaste produkten är " + lowestPrize.Name+ " och den kostar " +  lowestPrize.Prize+ "kr.");

           
        }
    }
}