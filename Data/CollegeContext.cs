
using Microsoft.EntityFrameworkCore;
namespace CollegeWebAbpi.Data
{
    public class CollegeContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<College> Colleges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=CollegeDB;user=root");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<College>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.HasOne(c => c.College)
                  .WithMany(p => p.Departments);
            });
        }
    }
}
