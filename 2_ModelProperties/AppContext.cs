using Microsoft.EntityFrameworkCore;

namespace _2_ModelProperties
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
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ObjectivesDB_002; Trusted_Connection=True");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Objective>().Ignore(x => x.DevProp);
        //}
    }
}
