using MediatRSample.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MediatRSample.Data.Entities;

namespace MediatRSample.API
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EmployeeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<EmployeeDbContext>>()))
            {
                // Look for any employees
                if (context.Employees.Any())
                {
                    return;   // Data was already seeded
                }

                context.Employees.AddRange(
                    new EmployeeEntity
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Bharani",
                        LastName= "Murugan",
                        
                    },
                     new EmployeeEntity
                     {
                         Id = Guid.NewGuid(),
                         FirstName = "Test",
                         LastName = "Name",

                     });

                context.SaveChanges();
            }
        }
    }
}
