using System;
using System.Linq;

namespace EFFrukt
{
    class Program
    {
        static FruitContext context = new FruitContext();

        static void Main(string[] args)
        {
            AddFruits();
            DisplayFruits();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();
              
        }

        private static void DisplayFruits()
        {
            foreach (var fruit in context.Fruits.OrderBy(x => x.Name))
            {
                Console.WriteLine(fruit.Id + " " + fruit.Name + " " + fruit.Price);
            }
        }

        private static void AddFruits()
        {
           
            var f = new Fruit
            {
                Name = "banan",
                Price = 8
            };
            var f2 = new Fruit
            {  
                Name = "äpple",
                Price = 5
            };

            context.Fruits.Add(f);
            context.Fruits.Add(f2);
            context.SaveChanges();
        }
    }
}
