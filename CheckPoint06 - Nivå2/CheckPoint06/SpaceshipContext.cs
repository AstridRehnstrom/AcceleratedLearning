using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint06
{
    public class SpaceshipContext : DbContext
    {
        public DbSet<Spaceship> Spaceships { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = EfSpaceship;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RavioliInSpaceship>().HasKey(x => new { x.RavioliId, x.SpaceshipId });
        }


    }
}
