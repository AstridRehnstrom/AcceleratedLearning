using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckPoint06
{
    class Program
    {
        static SpaceshipContext context = new SpaceshipContext();
        static void Main(string[] args)        
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millennium Falcon");
            AddSpaceship("Cylon Raider");

            List<Spaceship> list = GetAllSpaceships();
            DisplaySpaceships(list);
        }

        private static void DisplaySpaceships(List<Spaceship> list)
        {
            foreach (Spaceship spaceship in list)
            {
                Console.WriteLine(spaceship.Name);
            }
        }

        private static List<Spaceship> GetAllSpaceships()
        {
            return context.Spaceships.ToList();
        }

        private static void AddSpaceship(string name)
        {
            var spaceship = new Spaceship { Name = name };

            using (var context = new SpaceshipContext())
            {
                context.Spaceships.Add(spaceship);
                context.SaveChanges();
            }
        }

        private static void RecreateDatabase()
        {
            using (var context = new SpaceshipContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
