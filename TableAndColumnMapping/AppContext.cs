using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TableAndColumnMapping
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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ObjectivesDB_003; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Objective>().ToTable("Tasks");
            modelBuilder.Entity<Objective>().Property(o => o.Id).HasColumnName("task_id");
        }
    }
}
