using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_AlternateKeys
{
    public class AppContext : DbContext
    {
        public DbSet<Objective> Objectives { get; set; }
        public AppContext()
        {
            Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ObjectivesDB_005; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Objective>().HasAlternateKey(o => o.AltKey);
            modelBuilder.Entity<Objective>().HasAlternateKey(o => new { o.AltKey, o.PartOfKey });
        }
    }
}
