using Microsoft.EntityFrameworkCore;

// Step 3: Create the Data Model
namespace lab11_solution.Models
{
	public class ProfessorContext : DbContext
	{
		public ProfessorContext (DbContextOptions<ProfessorContext> options)
			: base(options)
		{
		}
		public DbSet<Professor> Professor {get; set;}
	}
}