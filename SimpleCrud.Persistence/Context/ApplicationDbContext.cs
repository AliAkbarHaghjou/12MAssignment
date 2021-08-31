using Microsoft.EntityFrameworkCore;
using SimpleCrud.Domain.Entities;
using SimpleCrud.Persistence.Configurations;

namespace SimpleCrud.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<STI> STIs { get; set; }
        public DbSet<STK> STKs { get; set; }
        public DbSet<STViewModel> ViewModels { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new STIConfiguration());
            modelBuilder.ApplyConfiguration(new STKConfiguration());
            modelBuilder.Entity<STViewModel>().HasNoKey();
        }

    }
}
