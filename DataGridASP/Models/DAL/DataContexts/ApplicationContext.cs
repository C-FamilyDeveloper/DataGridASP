using DataGridASP.Models.DAL.DataEntities;
using Microsoft.EntityFrameworkCore;
using Faker;

namespace DataGridASP.Models.DAL.DataContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<DataEntity> DataEntities { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            if (!DataEntities.Any())
            {
                Random random = new();
                for (int i = 0; i < 100000; i++) 
                {
                    DataEntities.Add(new DataEntity
                    {
                        FullName = Name.FullName(),
                        DateTime = DateTime.MinValue.AddDays(random.Next(1, 2000))
                    });
                }
                SaveChanges();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
