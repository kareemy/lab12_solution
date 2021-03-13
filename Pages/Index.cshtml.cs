using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using lab11_solution.Models;

namespace lab11_solution.Pages
{
    public class IndexModel : PageModel
    {
        // Step 8: Dependency Injection Part 2
        // IndexModel needs access to database, so we make DbContext variable here
        private readonly ProfessorContext _context;
        private readonly ILogger<IndexModel> _logger;
        // Property that represents our list of professors to display
        public List<Professor> Professors {get; set;}

        public IndexModel(ProfessorContext context, ILogger<IndexModel> logger)
        {
            _context = context; // Read in DbContext here
            _logger = logger;
        }

        public void OnGet()
        {
            // Read in all professors from the database
            // _context is our "db" variable, represents database
            Professors = _context.Professor.ToList();
        }
    }
}
