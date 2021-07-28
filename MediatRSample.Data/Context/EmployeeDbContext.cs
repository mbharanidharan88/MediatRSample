using MediatRSample.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatRSample.Data.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
                        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmployeeEntity>().ToTable("Course");
        }

        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
