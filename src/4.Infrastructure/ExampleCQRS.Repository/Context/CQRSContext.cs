namespace ExampleCQRS.Repository.Context
{
    using ExampleCQRS.Domain.Entities;
    using ExampleCQRS.Repository.Mappings;
    using Microsoft.EntityFrameworkCore;

    public class CQRSContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=[HOST];Port=[PORT];Database=modelo;Uid=[USER];Pwd=[PASSWORD]");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

		    modelBuilder.Entity<User>(new UserMap().Configure);
        }

        //DBSets
        public DbSet<User> User { get; set; }
    }
}