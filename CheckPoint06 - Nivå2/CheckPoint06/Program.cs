using Microsoft.EntityFrameworkCore;
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

            //AddRavioliForSpaceship("Cylon Raider", 1, new DateTime(2018 - 04 - 19));
            //AddRavioliForSpaceship("Millennium Falcon", 1, new DateTime (2017- 01-01));
            //AddRavioliForSpaceship("Millennium Falcon", 2, new DateTime(2018-01-01));
            //AddRavioliForSpaceship("Nalle Puh", 99, new DateTime(1950-01-01));

            List<Spaceship> list = GetAllSpaceships();
            DisplaySpaceships(list);
        }

        private static void AddRavioliForSpaceship(string name, int number, DateTime packed)
        {              
            var spaceship = new Spaceship
            {
                Name = name,
                RavioliInSpaceship = new List<RavioliInSpaceship>
                 {
                      new RavioliInSpaceship{ Ravioli=new Ravioli
                      {
                           Packed=packed
                      }
                      }
                 }
            };

            using (var context = new SpaceshipContext())
            {
                context.Spaceships.Add(spaceship);
                context.SaveChanges();
            }
        }

        private static void DisplaySpaceships(List<Spaceship> list)
        {
            using (var context = new SpaceshipContext())
            {
                foreach (var spaceship in context.Spaceships.Include(s => s.RavioliInSpaceship))

                {
                    Console.WriteLine(spaceship.Name);
                    

                }
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
