using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

// Step 7: Seed Data Class
namespace lab11_solution.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorContext(serviceProvider.GetRequiredService<DbContextOptions<ProfessorContext>>()))
            {
                if (context.Professor.Any())
                {
                    return;
                }

                context.Professor.AddRange(
                    new Professor { 
                        FirstName = "Kareem", 
                        LastName = "Dana"
                    },
                    new Professor { 
                        FirstName = "Jeff", 
                        LastName = "Babb"
                    },
                    new Professor { FirstName = "Sean", LastName = "Humpherys" }
                );
                context.SaveChanges();
            }
        }
  
    }
}